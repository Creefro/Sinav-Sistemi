using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Sistemi
{
    public class UserProvider
    {  
        public Users getUser(string kullaniciAdi, string password)
        {
            Users user = null;
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");
                
            SqlCommand command = new SqlCommand("SELECT *FROM Users WHERE KullaniciAdi='" + kullaniciAdi + "' and Password='" + password + "'");
            
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
 
        private bool ContainsUser(Users user)
        {
            bool result = false;
            using (var connection = Helper.GetConnection("SinavSistemiDB"))
            {
                SqlCommand command = new SqlCommand("SELECT *FROM Users WHERE KullaniciAdi='" + user.KullaniciAdi + "' OR Mail='" + user.Mail + "'");
                
                command.Connection = connection;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                    result = true;
                }
                connection.Close();
            }
            return result;
        }
 
        public bool InsertUser(Users user)
        {
            bool result = false;
            if (!ContainsUser(user))
            {
                SqlConnection connection = Helper.GetConnection("SinavSistemiDB");
                
                SqlCommand command = new SqlCommand("INSERT INTO Users (KullaniciAdi,Ad,Soyad,Password,Mail,UserTypeId) VALUES('" + user.KullaniciAdi + "','" + user.Ad + "','" + user.Soyad + "','" + user.Password + "','" + user.Mail + "','" + user.UserTypeId + "')");
                command.Connection = connection;
                connection.Open();
                if (command.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();
                
            }
            return result;
        }
        public bool ŞifreDeğiş(string kullanıcıAdı,string newPassword)
        {
            bool result = false;
            bool result1 = false;
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");

            SqlCommand command1 = new SqlCommand("SELECT *FROM Users WHERE KullaniciAdi='" + kullanıcıAdı + "'");
            command1.Connection = connection;
            connection.Open();
            SqlDataReader reader = command1.ExecuteReader();

            if (reader.Read())
            {
                result1 = true;
            }
            connection.Close();
            //containsUser metoduna benzer bir algoritma fakat containsUser Users tipinde
            //parametre alıyor. Bize direkt kullanıcı adının kendisi lazım ondan kod tekrarına
            //düşüldü.
            if (result1)
            {
                SqlCommand command = new SqlCommand("UPDATE Users SET Password='" + newPassword + "' WHERE KullaniciAdi = '" + kullanıcıAdı + "'");

                command.Connection = connection;
                connection.Open();

                if (command.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();

            }
                return result;
        }
        
    }
}
