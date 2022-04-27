using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinav_Sistemi
{
    public partial class KayıtEkranı : Form
    {
        public KayıtEkranı()
        {
            InitializeComponent();
        }

        //public Users user;
        //public UserProvider kayit;
        private void kayitOlButton_Click(object sender, EventArgs e)
        {
            UserProvider kayit = new UserProvider();
            Users user = new Users
            {
                KullaniciAdi = kAdiText.Text,
                Ad = adText.Text,
                Soyad = soyadText.Text,
                Password = sifreText.Text,
                Mail = epostaText.Text,
                UserTypeId = userTypeId()
            };
            if (kayit.InsertUser(user)&&SifreKontrol()==true)
            {
                MessageBox.Show("Kullanıcı Eklendi");
            }
            else
            {
                MessageBox.Show("Bu Kullanıcı adı var!");
            }
        }

        public bool SifreKontrol()
        {
            if (sifreText.Text != sifreTekrarText.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor. Lütfen kontrol edin.");
                return false;
            }
            else
                return true;
        }
        
        public int userTypeId()
        {
            if (ogrenciRadioButton.Checked)
            {
                return 1;
            }
            else
                return 2;
        }

        private void girisYapbttn_Click(object sender, EventArgs e)
        {
            GirişEkranı giriş = new GirişEkranı();
            this.Hide();
            giriş.Show();
        }
    }
}
