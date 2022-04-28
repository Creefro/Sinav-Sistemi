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
        public bool GetQuestion(ISoru question)
        {
            bool isOk = false;

            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");

            SqlCommand command = new SqlCommand("SELECT QuestionText,PicturePath,RightAnswer,WrongAnswer1,WrongAnswer2,WrongAnswer3 FROM Questions");
           
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                question.QuestionText = reader.GetString(0);
                question.PicturePath = reader.GetString(1);
                question.RightAnswer = reader.GetString(2);
                question.WrongAnswer1 = reader.GetString(3);
                question.WrongAnswer2 = reader.GetString(4);
                question.WrongAnswer3 = reader.GetString(5);
            }
            connection.Close();
           
            isOk = true;
            
            return isOk;
        }
    }                                       
}
