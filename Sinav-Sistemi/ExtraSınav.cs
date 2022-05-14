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
    public partial class ExtraSınav : Form
    {
        public ExtraSınav()
        {
            InitializeComponent();
        }
        static Random random = new Random();
        int sayac = 0;
        string answer;
        string selectedText;
        int dogruSayac = 0;
        private void nextQueButton_Click(object sender, EventArgs e)
        {
            ansA.Visible = true; ansB.Visible = true; ansC.Visible = true; ansD.Visible = true;
            ansA.Enabled = true; ansB.Enabled = true; ansC.Enabled = true; ansD.Enabled = true;
            button1.Visible = false;

            Questions questions = new Questions();
            List<ISoru> RastgeleSorular = questions.GetRandomQuestion(questions);
            //sorular db den listeye çekilir
            //liste boyutu kadar döndürülür
            if (sayac < RastgeleSorular.Count())
            {
                var item = RastgeleSorular.ElementAt(sayac);
                queText.Text = item.QuestionText;
                pictureBox1.Image = Image.FromFile(item.PicturePath);

                Button[] radioButtons = { ansA, ansB, ansC, ansD };
                int[] wrong = new int[3];

                int rand = random.Next(0, 4);//şıkları rastgele ayarlar

                if (rand == 0)
                    wrong = new int[] { 1, 2, 3 };
                else if (rand == 1)
                    wrong = new int[] { 0, 2, 3 };
                else if (rand == 2)
                    wrong = new int[] { 0, 1, 3 };
                else if (rand == 3)
                    wrong = new int[] { 0, 1, 2 };

                radioButtons[rand].Text = item.RightAnswer;

                radioButtons[wrong[0]].Text = item.WrongAnswer1;
                radioButtons[wrong[1]].Text = item.WrongAnswer2;
                radioButtons[wrong[2]].Text = item.WrongAnswer3;
                sayac++;
                answer = item.RightAnswer;
            }
            else
            {
                MessageBox.Show("Doğru sayısı: "+dogruSayac+"\nYanlış sayısı: "+(sayac-dogruSayac)+"","Sınav Bitti!");
                ÖğrenciGirişMain main = new ÖğrenciGirişMain();
                this.Hide();
                main.Location = this.Location;
                main.Show();
            }
        }

        private void ExtraSınav_Load(object sender, EventArgs e)
        {
            sayac = 0;
            ansA.Visible = false;
            ansB.Visible = false;
            ansC.Visible = false;
            ansD.Visible = false;
            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ansA.Enabled = false;
            ansB.Enabled = false;
            ansC.Enabled = false;
            ansD.Enabled = false;
            button1.Visible = false;
            if (selectedText == answer)
            {
                MessageBox.Show("Doğru Cevap!","Sonuç!");
                dogruSayac++;
            }
            else
                MessageBox.Show("Yanlış Cevap!","Sonuç!");
        }

        private void ansA_Click(object sender, EventArgs e)
        {
            selectedText = ((Button)sender).Text;
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÖğrenciGirişMain main = new ÖğrenciGirişMain();
            this.Hide();
            main.Location = this.Location;
            main.Show();
        }
    }
} 
