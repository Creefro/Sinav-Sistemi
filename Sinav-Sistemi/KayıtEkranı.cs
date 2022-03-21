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

        public Users user;
        public UserProvider kayit;
        private void kayitOlButton_Click(object sender, EventArgs e)
        {
            kayit = new UserProvider();
            user = new Users();
            user.KullaniciAdi = kAdiText.Text;
            user.Ad = adText.Text;
            user.Soyad = soyadText.Text;
            user.Password = sifreText.Text;
            user.Mail = epostaText.Text;
            user.UserTypeId = userTypeId();
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
