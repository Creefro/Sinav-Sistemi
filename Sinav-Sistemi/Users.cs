using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Sistemi
{
    public class Users
    {
        int userId;
        string kullaniciAdi;
        string ad;
        string soyad;
        string password;
        string mail;
        int userTypeId;
        public int UserId { get { return userId; }  set { userId = value; } }
        public string KullaniciAdi { get { return kullaniciAdi; } set { kullaniciAdi = value; } }
        public string Ad { get { return ad; } set { ad = value; } }
        public string Soyad { get { return soyad; } set { soyad = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Mail { get { return mail; } set { mail = value; } }
        public int UserTypeId { get { return userTypeId; } set { userTypeId = value; } }
    }
}
