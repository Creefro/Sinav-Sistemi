
namespace Sinav_Sistemi
{
    partial class Sigma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sigma));
            this.nextQueButton = new System.Windows.Forms.Button();
            this.queText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ansA = new System.Windows.Forms.Button();
            this.ansB = new System.Windows.Forms.Button();
            this.ansC = new System.Windows.Forms.Button();
            this.ansD = new System.Windows.Forms.Button();
            this.sigmaButton = new System.Windows.Forms.Button();
            this.quizButton = new System.Windows.Forms.Button();
            this.countDownTimer = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nextQueButton
            // 
            this.nextQueButton.BackColor = System.Drawing.Color.GhostWhite;
            this.nextQueButton.Location = new System.Drawing.Point(678, 491);
            this.nextQueButton.Name = "nextQueButton";
            this.nextQueButton.Size = new System.Drawing.Size(120, 42);
            this.nextQueButton.TabIndex = 8;
            this.nextQueButton.Text = "Sonraki Soru";
            this.nextQueButton.UseVisualStyleBackColor = false;
            this.nextQueButton.Click += new System.EventHandler(this.nextQueButton_Click);
            // 
            // queText
            // 
            this.queText.AutoSize = true;
            this.queText.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queText.Location = new System.Drawing.Point(12, 12);
            this.queText.MaximumSize = new System.Drawing.Size(450, 0);
            this.queText.Name = "queText";
            this.queText.Size = new System.Drawing.Size(0, 19);
            this.queText.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(469, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ansA
            // 
            this.ansA.BackColor = System.Drawing.Color.Snow;
            this.ansA.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ansA.Location = new System.Drawing.Point(468, 224);
            this.ansA.Name = "ansA";
            this.ansA.Size = new System.Drawing.Size(320, 58);
            this.ansA.TabIndex = 10;
            this.ansA.UseVisualStyleBackColor = false;
            this.ansA.Click += new System.EventHandler(this.ansA_Click);
            // 
            // ansB
            // 
            this.ansB.BackColor = System.Drawing.Color.Snow;
            this.ansB.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ansB.Location = new System.Drawing.Point(469, 288);
            this.ansB.Name = "ansB";
            this.ansB.Size = new System.Drawing.Size(319, 58);
            this.ansB.TabIndex = 11;
            this.ansB.UseVisualStyleBackColor = false;
            this.ansB.Click += new System.EventHandler(this.ansA_Click);
            // 
            // ansC
            // 
            this.ansC.BackColor = System.Drawing.Color.Snow;
            this.ansC.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ansC.Location = new System.Drawing.Point(469, 352);
            this.ansC.Name = "ansC";
            this.ansC.Size = new System.Drawing.Size(319, 58);
            this.ansC.TabIndex = 12;
            this.ansC.UseVisualStyleBackColor = false;
            this.ansC.Click += new System.EventHandler(this.ansA_Click);
            // 
            // ansD
            // 
            this.ansD.BackColor = System.Drawing.Color.Snow;
            this.ansD.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ansD.Location = new System.Drawing.Point(469, 416);
            this.ansD.Name = "ansD";
            this.ansD.Size = new System.Drawing.Size(319, 58);
            this.ansD.TabIndex = 13;
            this.ansD.UseVisualStyleBackColor = false;
            this.ansD.Click += new System.EventHandler(this.ansA_Click);
            // 
            // sigmaButton
            // 
            this.sigmaButton.BackColor = System.Drawing.Color.GhostWhite;
            this.sigmaButton.Location = new System.Drawing.Point(547, 491);
            this.sigmaButton.Name = "sigmaButton";
            this.sigmaButton.Size = new System.Drawing.Size(120, 42);
            this.sigmaButton.TabIndex = 14;
            this.sigmaButton.Text = "Cevabı Kaydet";
            this.sigmaButton.UseVisualStyleBackColor = false;
            this.sigmaButton.Click += new System.EventHandler(this.sigmaButton_Click);
            // 
            // quizButton
            // 
            this.quizButton.BackColor = System.Drawing.Color.GhostWhite;
            this.quizButton.Location = new System.Drawing.Point(547, 491);
            this.quizButton.Name = "quizButton";
            this.quizButton.Size = new System.Drawing.Size(120, 42);
            this.quizButton.TabIndex = 15;
            this.quizButton.Text = "Cevabı Kaydet";
            this.quizButton.UseVisualStyleBackColor = false;
            this.quizButton.Click += new System.EventHandler(this.quizButton_Click);
            // 
            // countDownTimer
            // 
            this.countDownTimer.BackColor = System.Drawing.Color.MistyRose;
            this.countDownTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countDownTimer.Location = new System.Drawing.Point(13, 499);
            this.countDownTimer.Name = "countDownTimer";
            this.countDownTimer.Size = new System.Drawing.Size(124, 30);
            this.countDownTimer.TabIndex = 16;
            this.countDownTimer.Text = "00:00:00";
            this.countDownTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GhostWhite;
            this.button3.Location = new System.Drawing.Point(143, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sınavı Sonlandır";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Sigma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(816, 546);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.countDownTimer);
            this.Controls.Add(this.quizButton);
            this.Controls.Add(this.sigmaButton);
            this.Controls.Add(this.ansD);
            this.Controls.Add(this.ansC);
            this.Controls.Add(this.ansB);
            this.Controls.Add(this.ansA);
            this.Controls.Add(this.nextQueButton);
            this.Controls.Add(this.queText);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sigma";
            this.Text = "Sigma Sınav";
            this.Load += new System.EventHandler(this.Sigma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nextQueButton;
        private System.Windows.Forms.Label queText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ansA;
        private System.Windows.Forms.Button ansB;
        private System.Windows.Forms.Button ansC;
        private System.Windows.Forms.Button ansD;
        private System.Windows.Forms.Button sigmaButton;
        private System.Windows.Forms.Button quizButton;
        private System.Windows.Forms.TextBox countDownTimer;
        private System.Windows.Forms.Button button3;
    }
}