using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinav_Sistemi
{
    public partial class ŞifreDeğiştir : Form
    {
        public ŞifreDeğiştir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserProvider get = new UserProvider();
            
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
                ŞifreDeğiştir frm = new ŞifreDeğiştir();
                this.Hide();
                frm.Show();
                return;
            }
            else if (textBox2.Text == textBox3.Text)
            {
                MessageBox.Show("Yeni şifre mevcut şifre ile aynı olamaz!");
                ŞifreDeğiştir frm = new ŞifreDeğiştir();
                this.Hide();
                frm.Show();
                return;
            }
            else if(textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Şifreler aynı olmak zorunda!");
                ŞifreDeğiştir frm = new ŞifreDeğiştir();
                this.Hide();
                frm.Show();
                return;
            }
            else
            {
                bool result = get.ŞifreDeğiş(textBox1.Text, textBox2.Text, textBox3.Text);

                if (result)
                {
                    MessageBox.Show("Şifre başarıyla değiştirildi.");
                    GirişEkranı main = new GirişEkranı();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Hata!");
                    return;
                }

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirişEkranı girişEkranı = new GirişEkranı();
            this.Hide();
            girişEkranı.Location = this.Location;
            girişEkranı.Show();
        }
    }
}
