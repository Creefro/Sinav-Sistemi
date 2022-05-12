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

        public static Users user;
        public UserProvider giris;
        private void girisYap_Click(object sender, EventArgs e)
        {
            giris = new UserProvider();
            user = giris.getUser(kullaniciAdiTextBox.Text, sifreTextBox.Text);
            if (user != null)
            {
                if (user.UserTypeId == 2)
                {
                    SınavEkle main = new SınavEkle();
                    this.Hide();
                    main.Show();
                }
                else if (user.UserTypeId == 1)
                {
                    ÖğrenciGirişMain main = new ÖğrenciGirişMain();
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

        private void label3_Click(object sender, EventArgs e)
        {
            ŞifreDeğiştir frm = new ŞifreDeğiştir();
            this.Hide();
            frm.Show();
        }
    }
}
