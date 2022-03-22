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
                user.KullaniciAdi = reader.GetString(1);   //name
                user.Password = reader.GetString(4);  //password
            }
            connection.Close();
            
            return user;
        }
 
        private bool ContainsUser(Users user)
        {
            bool result = false;
            using (var connection = Helper.GetConnection("SinavSistemiDB"))
            {
                SqlCommand command = new SqlCommand("SELECT *FROM Users WHERE KullaniciAdi='" + user.KullaniciAdi + "'");
                
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
    }
}
