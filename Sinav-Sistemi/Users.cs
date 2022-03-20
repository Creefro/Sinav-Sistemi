using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Sistemi
{
    public class Users
    {
        public int UserId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public int UserTypeId { get; set; }
    }
}
