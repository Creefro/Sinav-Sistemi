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

        private void girisYap_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Helper.CnnVal("SinavSistemiDB"));
            string query = "Select * from Users Where KullaniciAdi = '" + kullaniciAdiTextBox.Text.Trim() + "' and Password = '" + sifreTextBox.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query,sqlcon);
            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Main formMain = new Main();
                this.Hide();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı ama hangisi söylemem.");
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
