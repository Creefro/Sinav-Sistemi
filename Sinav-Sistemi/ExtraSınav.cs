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
        private void ExtraSınav_Load(object sender, EventArgs e)
        {
            Questions questions = new Questions();
            queText.Text = questions.QuestionText;
            pictureBox1.Image = Image.FromFile(questions.PicturePath);
            
            string[] labels = { ansA.Text, ansB.Text, ansC.Text, ansD.Text };
            int[] wrongs = new int[3];
            
            int a = random.Next(0, 3);
            
            if (a == 0)
                wrongs = new int[] { 1, 2, 3 };
            else if (a == 1)
                wrongs = new int[] { 0, 2, 3 };
            else if (a == 2)
                wrongs = new int[] { 0, 1, 3 };
            else if (a == 3)
                wrongs = new int[] { 0, 1, 2 };
            
            labels[a] = questions.RightAnswer;
            
            labels[wrongs[0]] = questions.WrongAnswer1;
            labels[wrongs[1]] = questions.WrongAnswer1;
            labels[wrongs[2]] = questions.WrongAnswer1;
        }

        private void nextQueButton_Click(object sender, EventArgs e)
        {

        }
    }
} 
