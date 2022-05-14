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
        bool sigmaDone = false;
        public Sigma()
        {
            InitializeComponent();
        }
        List<ISoru> sorular;
        static Random random;
        int rastgeleSayac;
        string selectedText,answer;
        int questionId;
        int dogruSayac = 0;
        int sayac;
        private void nextQueButton_Click(object sender, EventArgs e)
        {
            AnsButtons();
            sigmaButton.Visible = false;
            quizButton.Visible = false;
            random = new Random();
           
            if (sayac<sorular.Count())
            {
                SoruGetir();
            }
            else
            {
                sigmaDone = true;
                RastgeleTest();
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
                //10 soruluk quiz için timer başlatır
            }
            else
                isTimerOn = true;

            
            if (rastgeleSayac < RastgeleSorular.Count())
            {
                RastgeleSoruGetir();
            }
            else
            {
                MessageBox.Show("Doğru sayısı: " + dogruSayac + "\nYanlış sayısı: " + (sayac + rastgeleSayac - dogruSayac) + "\nDoğru oranı: %"+ 100*dogruSayac/(rastgeleSayac+sayac) , "Sınav Bitti");
                ÖğrenciGirişMain main = new ÖğrenciGirişMain();
                this.Hide();
                main.Location = this.Location;
                main.Show();
            }
           
        }
        private void Sigma_Load(object sender, EventArgs e)
        {
            rastgeleSayac = 0;
            sayac = 0;
            dogruSayac = 0;

            sorular = questions.BilinenSoruGetir(GirişEkranı.user); //sigma sorularını listeye atar
            RastgeleSorular = questions.GetRandomQuestion(questions);// rastgele 10 soruyu listeye atar

            ansA.Visible = false; ansB.Visible = false; ansC.Visible = false; ansD.Visible = false;
            sigmaButton.Visible = false;
            quizButton.Visible = false;

            timer = new System.Timers.Timer();
            timer.Interval = 1000; //1s
            timer.Elapsed += OnTimeEvent;
            isTimerOn = false;
        }
        private void OnTimeEvent (object sender, System.Timers.ElapsedEventArgs e)
        {
            // countdown algoritması
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
                    main.Location = sigma.Location;
                    main.Show();
                }
            }));
        }
        private void ansA_Click(object sender, EventArgs e)
        {
            selectedText = ((Button)sender).Text;
            if(sigmaDone)
            {
                quizButton.Enabled = true;
                quizButton.Visible = true;
            }
            else
            {
                sigmaButton.Enabled = true;
                sigmaButton.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÖğrenciGirişMain main = new ÖğrenciGirişMain();
            this.Hide();
            main.Location = this.Location;
            main.Show();
        }

        private void sigmaButton_Click(object sender, EventArgs e)
        {
            cvpButtonEnabled();
            sigmaButton.Enabled = false;

            if (selectedText == answer)//seçilen cevap doğruysa
            {
                dogruSayac++;
                questions.DogruSoruBilgiGuncelle(questionId, GirişEkranı.user);
            }
            else
            {
                questions.YanlışSoruSil(questionId, GirişEkranı.user);
            }
        }

        private void quizButton_Click(object sender, EventArgs e)
        {
            cvpButtonEnabled();
            quizButton.Enabled = false;

            if (selectedText == rastgeleQuestionAnswer)//seçilen cevap doğruysa
            {
                dogruSayac++;
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
        void AnsButtons()
        {
            ansA.Visible = true; ansB.Visible = true; ansC.Visible = true; ansD.Visible = true;
            ansA.Enabled = true; ansB.Enabled = true; ansC.Enabled = true; ansD.Enabled = true;
            nextQueButton.Enabled = false;
        }
        void RastgeleSoruGetir()
        {
             var item = RastgeleSorular.ElementAt(rastgeleSayac);// listedeki rastgeleSayaç numaralı soruyu getir
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

                //şıklar rastgele karıştırıldı

                rastgeleSayac++;
                rastgeleQuestionAnswer = item.RightAnswer;
                rastgeleQuestionId = item.QuestionId;

        }
        void SoruGetir()
        {
            var item = sorular.ElementAt(sayac); //listedeki sayac numaralı sigma sorusunu getirir
            queText.Text = item.QuestionText;
            pictureBox1.Image = Image.FromFile(item.PicturePath);

            Button[] siklar = { ansA, ansC, ansB, ansD };
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

            //şıklar rastgele karıştırıldı

            sayac++;

            answer = item.RightAnswer;
            questionId = item.QuestionId;
        }
    }
}
