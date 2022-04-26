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
        Question question;
        private void button1_Click(object sender, EventArgs e)
        {
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
            question = new Question();
            question.QuestionText = richTextBox1.Text;
            question.SectionId = Convert.ToInt32(numericUpDown1.Value);
            question.UnitId = Convert.ToInt32(numericUpDown2.Value);
            question.PicturePath = picpathlabel.Text;
            question.RightAnswer = rightansTxBox.Text;
            question.WrongAnswer1 = textBox2.Text;
            question.WrongAnswer2 = textBox3.Text;
            question.WrongAnswer3 = textBox4.Text;
        }
    }
}
