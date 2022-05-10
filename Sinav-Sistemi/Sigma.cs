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
    public partial class Sigma : Form
    {
        public Sigma()
        {
            InitializeComponent();
        }
        static Random random;
        int sayac;
        int rastgeleSayac;
        String selectedText;
        private void nextQueButton_Click(object sender, EventArgs e)
        {

            random = new Random();
            Questions questions = new Questions();
            List<ISoru> sorular = questions.Function(GirişEkranı.user);
            if (sayac<sorular.Count())
            { 
                var item = sorular.ElementAt(sayac);
                queText.Text = item.QuestionText;
                pictureBox1.Image = Image.FromFile(item.PicturePath);

                RadioButton[] siklar = { ansA, ansC, ansB, ansD};
                int[] wrongs = new int[3];

                int a = random.Next(0, 4);

                if (a == 0)
                    wrongs = new int[] { 1, 2, 3 };
                else if (a == 1)
                    wrongs = new int[] { 0, 2, 3 };
                else if (a == 2)
                    wrongs = new int[] { 0, 1, 3 };
                else if (a == 3)
                    wrongs = new int[] { 0, 1, 2 };

                siklar[a].Text = item.RightAnswer;

                siklar[wrongs[0]].Text = item.WrongAnswer1;
                siklar[wrongs[1]].Text = item.WrongAnswer2;
                siklar[wrongs[2]].Text = item.WrongAnswer3;
                sayac++;
                List<string> bilinenSoruCevaplar = new List<string>();
                bilinenSoruCevaplar.Add(selectedText);
            }
            else
            {
                RastgeleTest();
            }

        }
        Questions questions = new Questions();
        List<ISoru> RastgeleSorular;
        private void RastgeleTest()
        {
            if (rastgeleSayac < RastgeleSorular.Count())
            {
                var item = RastgeleSorular.ElementAt(rastgeleSayac);
                queText.Text = item.QuestionText;
                pictureBox1.Image = Image.FromFile(item.PicturePath);

                RadioButton[] radioButtons= { ansA, ansB, ansC, ansD };
                int[] wrong = new int[3];

                int rand = random.Next(0, 4);

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
                rastgeleSayac++;
                List<string> rastgeleSoruCevaplar = new List<string>();
                rastgeleSoruCevaplar.Add(selectedText);
            }
            else
            {
                MessageBox.Show("Sınav Bitti");
            }
           
        }
        private void Sigma_Load(object sender, EventArgs e)
        {
            rastgeleSayac = 0;
            sayac = 0;
            RastgeleSorular = questions.GetRandomQuestion(questions);

        }
        

        private void Sik_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                selectedText = ((RadioButton)sender).Text;
        }
    }
}
