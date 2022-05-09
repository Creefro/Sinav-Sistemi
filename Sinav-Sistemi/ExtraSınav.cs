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

        private void nextQueButton_Click(object sender, EventArgs e)
        {
            Questions questions = new Questions();
            ISoru soru;
            soru = questions.GetRandomQuestion(questions);
            queText.Text = soru.QuestionText;
            pictureBox1.Image = Image.FromFile(soru.PicturePath);

            Label[] labels = { ansA, ansB, ansC, ansD};
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

            labels[a].Text = soru.RightAnswer;
            
            labels[wrongs[0]].Text = soru.WrongAnswer1;
            labels[wrongs[1]].Text = soru.WrongAnswer1;
            labels[wrongs[2]].Text = soru.WrongAnswer1;
        }

        private void secim_Click(object sender, EventArgs e)
        {
            
        }
    }
} 
