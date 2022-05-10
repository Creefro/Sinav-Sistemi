using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Sistemi
{
    class Ogrenci:Users
    {
        public Users getUser(string kullaniciAdi, string password)
        {
            Users user = null;
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");

            SqlCommand command = new SqlCommand("SELECT o.QuestionId,o.DogruSayac FROM Ogrenci O INNER JOIN Users U ON U.UserId=O.UserId AND U.UserId = " + password + "");

            command.Connection = connection;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                user = new Users();
                user.UserId = reader.GetInt32(0); //id
                user.KullaniciAdi = reader.GetString(1);   //kname
                user.Ad = reader.GetString(2); //ad
                user.Soyad = reader.GetString(3); //soyad
                user.Password = reader.GetString(4);  //password
                user.Mail = reader.GetString(5); //mail
                user.UserTypeId = reader.GetInt32(6);
            }
            connection.Close();

            return user;
        }

    }
}
