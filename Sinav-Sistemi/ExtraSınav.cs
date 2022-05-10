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
        int sayac;
        private void nextQueButton_Click(object sender, EventArgs e)
        {
            Questions questions = new Questions();
            List<ISoru> RastgeleSorular = questions.GetRandomQuestion(questions);
            if (sayac < RastgeleSorular.Count())
            {
                var item = RastgeleSorular.ElementAt(sayac);
                queText.Text = item.QuestionText;
                pictureBox1.Image = Image.FromFile(item.PicturePath);

                Label[] label = { ansA, ansB, ansC, ansD };
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

                label[rand].Text = item.RightAnswer;

                label[wrong[0]].Text = item.WrongAnswer1;
                label[wrong[1]].Text = item.WrongAnswer2;
                label[wrong[2]].Text = item.WrongAnswer3;
                sayac++;
            }
            else
            {
                //sınav bitti
            }
        }

        private void secim_Click(object sender, EventArgs e)
        {
            
        }

        private void ExtraSınav_Load(object sender, EventArgs e)
        {
            sayac = 0;
        }
    }
} 
