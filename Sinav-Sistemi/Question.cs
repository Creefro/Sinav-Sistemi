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
        public ISoru GetQuestion(ISoru question)
        {
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");

            SqlCommand command = new SqlCommand("SELECT * FROM Questions");
           
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                question.QuestionId = reader.GetInt32(0);
                question.QuestionText = reader.GetString(1);
                question.SectionId = reader.GetInt32(2);
                question.UnitId = reader.GetInt32(3);
                question.PicturePath = reader.GetString(4);
                question.RightAnswer = reader.GetString(5);
                question.WrongAnswer1 = reader.GetString(6);
                question.WrongAnswer2 = reader.GetString(7);
                question.WrongAnswer3 = reader.GetString(8);
            }
            connection.Close();

            return question;
        }
        public List<ISoru> GetRandomQuestion(ISoru question)
        {
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
        public List<ISoru> Function(Users ogrenci)
        {
            List<ISoru> questions = new List<ISoru>();
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");

            SqlCommand command = new SqlCommand("SELECT *FROM Ogrenci O INNER JOIN Users U ON U.UserId=O.UserId Inner join Questions Q ON o.QuestionId = q.QuestionId  AND U.UserId = " + ogrenci.UserId + " and q.AdminOnay=1 ",connection);

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
    }                                       
}
