using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Sistemi
{
    class SinavGorevlisi : Users
    {
        public int SicilNo { get; set; }
        public Questions question;

        public SinavGorevlisi()
        {
            question = new Questions();
        }
        public bool InsertQuestion(Questions question)
        {
            //soru ekle
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
    }
}

