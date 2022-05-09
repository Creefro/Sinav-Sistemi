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
        public ISoru GetRandomQuestion(ISoru question)
        {
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");

            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Questions ORDER BY NEWID()");

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
    }                                       
}
