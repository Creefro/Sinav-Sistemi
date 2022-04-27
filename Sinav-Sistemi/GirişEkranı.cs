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
    public partial class GirişEkranı : Form
    {
        
        public GirişEkranı()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public Users user;
        public UserProvider giris;
        private void girisYap_Click(object sender, EventArgs e)
        {
            giris = new UserProvider();
            user = giris.getUser(kullaniciAdiTextBox.Text, sifreTextBox.Text);
            if (user != null)
            {
                if (user.UserTypeId == 2)
                {
                    ÖğretmenGirişMain main = new ÖğretmenGirişMain();
                    this.Hide();
                    main.Show();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış ama hangisi söylemem.");
            }

        }

        private void kayitOl_Click(object sender, EventArgs e)
        {
            KayıtEkranı kyt = new KayıtEkranı();
            this.Hide();
            kyt.Show();
        }
    }
}
