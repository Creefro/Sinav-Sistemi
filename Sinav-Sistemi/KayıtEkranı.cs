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

        private void kayitOlButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Helper.CnnVal("SinavSistemiDB"));
            sqlcon.Open();
            string query = "INSERT INTO Users (KullaniciAdi,Ad,Soyad,Password,Mail,UserTypeId) VALUES (@KullaniciAdi,@Ad,@Soyad,@Password,@Mail,@UserTypeId)";
            SqlCommand cmd = new SqlCommand(query,sqlcon);

            if (SifreKontrol() == true && UniqueKullaniciAdi() == true)
            {
                cmd.Parameters.AddWithValue("@KullaniciAdi", kAdiText.Text);
                cmd.Parameters.AddWithValue("@Ad", adText.Text);
                cmd.Parameters.AddWithValue("@Soyad", soyadText.Text);
                cmd.Parameters.AddWithValue("@Password", sifreText.Text);
                cmd.Parameters.AddWithValue("@Mail", epostaText.Text);
                cmd.Parameters.AddWithValue("@UserTypeId", userTypeId());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt tamamlandı. Giriş yapabilirsiniz.");
            }
            else
                MessageBox.Show("Bilgilerinizi kontrol ediniz.");
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
        public bool UniqueKullaniciAdi()
        {
            SqlConnection sqlcon = new SqlConnection(Helper.CnnVal("SinavSistemiDB"));
            string query = "Select * from Users Where KullaniciAdi = '" + kAdiText.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("Bu kullanıcı adı zaten alınmış. Başka bir şey bul.");
                return false;
            }
            else
            {
                return true;
            }
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
