using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Sistemi
{
    public class Questions:ISoru
    {
        //Concreate Product
        public override bool InsertQuestion(ISoru question)
        {
            //yeni soru ekler
            bool result = false;

            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");

            SqlCommand command = new SqlCommand("INSERT INTO Questions (QuestionText,SectionId,UnitId,PicturePath,RightAnswer,WrongAnswer1,WrongAnswer2,WrongAnswer3) VALUES('" + question.QuestionText + "','" + question.SectionId + "','" + question.UnitId + "','" + question.PicturePath + "','" + question.RightAnswer + "','" + question.WrongAnswer1 + "','" + question.WrongAnswer2 + "','" + question.WrongAnswer3 + "')");
            command.Connection = connection;
            connection.Open();
            if (command.ExecuteNonQuery() != -1)
            {
                result = true;
            }
            connection.Close();

            return result;
        }
        public Ogrenci GetQuestion(Users ogrenci,int questionId)
        {
            //Ogrenci tablosundan Soru Id sine bağlı soru çeker
            Ogrenci _ogrenci = null;
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");

            SqlCommand command = new SqlCommand("SELECT *FROM Ogrenci Where UserId = " + ogrenci.UserId + "and QuestionId = "+questionId+"");

            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                _ogrenci = new Ogrenci();
                _ogrenci.dogruSayac = reader.GetInt32(2);
                _ogrenci.sonCozulme = reader.GetDateTime(3);
                _ogrenci.sonrakiCozulme = reader.GetDateTime(4);
            }
            connection.Close();

            return _ogrenci;
        }
        public List<ISoru> GetRandomQuestion(ISoru question)
        {
            // 10 soruluk quiz için soru çeker
            List<ISoru> questions = new List<ISoru>();
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");

            SqlCommand command = new SqlCommand("SELECT TOP 10 * FROM Questions ORDER BY NEWID()");

            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                questions.Add(new Questions
                {
                    QuestionId = reader.GetInt32(0),
                    QuestionText = reader.GetString(1),
                    SectionId = reader.GetInt32(2),
                    UnitId = reader.GetInt32(3),
                    PicturePath = reader.GetString(4),
                    RightAnswer = reader.GetString(5),
                    WrongAnswer1 = reader.GetString(6),
                    WrongAnswer2 = reader.GetString(7),
                    WrongAnswer3 = reader.GetString(8)
                });
            }
            connection.Close();

            return questions;
        }
        public List<ISoru> BilinenSoruGetir(Users ogrenci)
        {
            // sigma soruları için soru çeker
            List<ISoru> questions = new List<ISoru>();
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");
            
            SqlCommand command = new SqlCommand("SELECT *FROM Ogrenci O INNER JOIN Users U ON U.UserId=O.UserId Inner join Questions Q ON o.QuestionId = q.QuestionId  AND U.UserId = " + ogrenci.UserId + " and q.AdminOnay=1 and o.SonrakiCozulme=CAST( GETDATE() AS Date )", connection);

            command.CommandType = System.Data.CommandType.Text;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                questions.Add(new Questions
                {
                    QuestionId = reader.GetInt32(1),
                    QuestionText = reader.GetString(13),
                    SectionId = reader.GetInt32(14),   
                    UnitId = reader.GetInt32(15),
                    PicturePath = reader.GetString(16),
                    RightAnswer = reader.GetString(17),
                    WrongAnswer1 = reader.GetString(18),
                    WrongAnswer2 = reader.GetString(19),
                    WrongAnswer3 = reader.GetString(20)
            });
            }
            connection.Close();
            return questions;
        }
        public void DogruSoruBilgiGuncelle(int soruId,Users ogrenci)
        {
            // sigma sorusunu doğru bilince bir sonraki tarihe atar
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");
            var _ogrenci = GetQuestion(ogrenci,soruId);
            string[] yeniAralık = ÖğrenciAyarlarMenü.degisenAralık; 
            string arttırmaTipi ="";
            int arttırmaSayısı = 0;
            // değişken soru görme tarihleri
            if (_ogrenci.dogruSayac == 1)
            {
                arttırmaTipi = yeniAralık[0];
                arttırmaSayısı = Convert.ToInt32(yeniAralık[1]);
            }
            else if (_ogrenci.dogruSayac == 2)
            {
                arttırmaTipi = yeniAralık[2];
                arttırmaSayısı = Convert.ToInt32(yeniAralık[3]);
            }
            else if (_ogrenci.dogruSayac == 3)
            {
                arttırmaTipi = yeniAralık[4];
                arttırmaSayısı = Convert.ToInt32(yeniAralık[5]);
            }
            else if (_ogrenci.dogruSayac == 4)
            {
                arttırmaTipi = yeniAralık[6];
                arttırmaSayısı = Convert.ToInt32(yeniAralık[7]);
            }
            else if (_ogrenci.dogruSayac == 5)
            {
                arttırmaTipi = yeniAralık[8];
                arttırmaSayısı = Convert.ToInt32(yeniAralık[9]);
            }
            else
                Console.WriteLine("Hata");

            SqlCommand command = new SqlCommand("UPDATE Ogrenci SET DogruSayac =" + (_ogrenci.dogruSayac + 1) + ", SonCozulme = GETDATE(), SonrakiCozulme = DATEADD("+arttırmaTipi+"," +arttırmaSayısı+",SonrakiCozulme) WHERE QuestionId = " + soruId + " and UserId="+ ogrenci.UserId+"");

            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();
            
            connection.Close();
        }
        public void YanlışSoruSil(int soruId, Users ogrenci)
        {
            //bilinen soruyu yanlış yaparsa db den siler
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");
            
            SqlCommand command = new SqlCommand("Delete from Ogrenci where UserId ="+ogrenci.UserId+" and QuestionId ="+soruId+"");

            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
        public void BilinenSoruEkle(Users ogrenciId,int questionId)
        {
            //quizde soru bildiği zaman havuza ekler
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");

            SqlCommand command = new SqlCommand("INSERT INTO Ogrenci (UserId,QuestionId,DogruSayac,SonCozulme,SonrakiCozulme) VALUES (" + ogrenciId.UserId + "," + questionId + ",1,GETDATE(),DATEADD(day,1,GETDATE()))");

            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
    }                                       
}
