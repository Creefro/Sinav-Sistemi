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
    public partial class SınavEkle : Form
    {
        public SınavEkle()
        {
            InitializeComponent();
        }
        Image file;
        
        private void button1_Click(object sender, EventArgs e)
        {
            //soru görselini ekler
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG (*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(f.FileName);
                pictureBox1.Image = file;
                picpathlabel.Text = f.FileName;
            }
        }
        
        //soruyu kaydet
        private void button3_Click(object sender, EventArgs e)
        {
            QuestionCreator creator = new SoruOluşturucu();
            bool result = creator.SoruyuKaydet(richTextBox1.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), picpathlabel.Text, rightansTxBox.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            if (result)
            {
                MessageBox.Show("Soru Başarıyla Eklendi","Başarılı!");
            }
            else
            {
                MessageBox.Show("Lütfen beklenen değerleri giriniz.","Hata!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirişEkranı main = new GirişEkranı();
            this.Hide();
            main.Location = this.Location;
            main.Show();
        }
    }
}
