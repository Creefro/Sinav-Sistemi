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
        System.Timers.Timer timer;
        int hour, minute = 10, second;
        bool isTimerOn;
        public Sigma()
        {
            InitializeComponent();
        }
        static Random random;
        int sayac;
        int rastgeleSayac;
        string selectedText;
        string answer;
        int questionId;
        private void nextQueButton_Click(object sender, EventArgs e)
        {
            

            ansA.Enabled = true;
            ansB.Enabled = true;
            ansC.Enabled = true;
            ansD.Enabled = true;
            button1.Enabled = true;
            button1.Visible = true;
            button2.Visible = false;
            nextQueButton.Enabled = false;
            random = new Random();
            Questions questions = new Questions();
            List<ISoru> sorular = questions.BilinenSoruGetir(GirişEkranı.user);
            if (sayac<sorular.Count())
            {
                var item = sorular.ElementAt(sayac);
                queText.Text = item.QuestionText;
                pictureBox1.Image = Image.FromFile(item.PicturePath);

                Button[] siklar = { ansA, ansC, ansB, ansD};
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
                
                answer = item.RightAnswer;
                questionId = item.QuestionId;
            }
            else
            {
                button1.Enabled = false;
                RastgeleTest();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            cvpButtonEnabled();
            button1.Enabled = false;

            if (selectedText == answer)
            {
                questions.DogruSoruBilgiGuncelle(questionId, GirişEkranı.user);
            }
            else if (selectedText == null)
            {
                MessageBox.Show("Sınav Başladı!");
            }
            else
            {
                questions.YanlışSoruSil(questionId, GirişEkranı.user);
            }
        }

        Questions questions = new Questions();
        List<ISoru> RastgeleSorular;
        int rastgeleQuestionId;
        string rastgeleQuestionAnswer;
        private void RastgeleTest()
        {
            if (!isTimerOn)
            {
                timer.Start();
            }
            else
                isTimerOn = true;

            button2.Enabled = true;
            button2.Visible = true;
            button1.Visible = false;
            if (rastgeleSayac < RastgeleSorular.Count())
            {
                var item = RastgeleSorular.ElementAt(rastgeleSayac);
                queText.Text = item.QuestionText;
                pictureBox1.Image = Image.FromFile(item.PicturePath);

                Button[] radioButtons= { ansA, ansB, ansC, ansD };
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
                rastgeleQuestionAnswer = item.RightAnswer;
                rastgeleQuestionId = item.QuestionId;

            }
            else
            {
                MessageBox.Show("Sınav Bitti");
                ÖğrenciGirişMain main = new ÖğrenciGirişMain();
                this.Hide();
                main.Show();
                ansA.Enabled = false;
                ansB.Enabled = false;
                ansC.Enabled = false;
                ansD.Enabled = false;
                button1.Enabled = false;
                nextQueButton.Enabled = false;
            }
           
        }
        private void Sigma_Load(object sender, EventArgs e)
        {
            rastgeleSayac = 0;
            sayac = 0;
            RastgeleSorular = questions.GetRandomQuestion(questions);
            ansA.Enabled = false;
            ansB.Enabled = false;
            ansC.Enabled = false;
            ansD.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;

            timer = new System.Timers.Timer();
            timer.Interval = 1000; //1s
            timer.Elapsed += OnTimeEvent;
            isTimerOn = false;
        }
        private void OnTimeEvent (object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (second == 0)
                {
                    second = 60;
                    minute -= 1;
                }
                if(minute == 0&&hour!=0)
                {
                    minute = 60;
                    hour -= 1;
                }
                second -= 1;
                countDownTimer.Text = string.Format("{0}:{1}:{2}", hour.ToString().PadLeft(2, '0'), minute.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2,'0'));
                if (minute == 0 && second == 0)
                {
                    timer.Stop();
                    MessageBox.Show("Süre bitti!");
                    ÖğrenciGirişMain main = new ÖğrenciGirişMain();
                    Sigma sigma = this;
                    sigma.Hide();
                    main.Show();
                    ansA.Enabled = false;
                    ansB.Enabled = false;
                    ansC.Enabled = false;
                    ansD.Enabled = false;
                    button1.Enabled = false;
                    nextQueButton.Enabled = false;
                }
            }));
        }
        private void ansA_Click(object sender, EventArgs e)
        {
            selectedText = ((Button)sender).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÖğrenciGirişMain main = new ÖğrenciGirişMain();
            this.Hide();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cvpButtonEnabled();
            button2.Enabled = false;

            if (selectedText == rastgeleQuestionAnswer)
            {
                questions.BilinenSoruEkle(GirişEkranı.user, rastgeleQuestionId);
            }
            else
                Console.WriteLine("yanlış cevap");
        }
        private void cvpButtonEnabled()
        {
            ansA.Enabled = false;
            ansB.Enabled = false;
            ansC.Enabled = false;
            ansD.Enabled = false;
            nextQueButton.Enabled = true;
        }
    }
}
