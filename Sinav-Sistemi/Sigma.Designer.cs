
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
            this.nextQueButton = new System.Windows.Forms.Button();
            this.queText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ansA = new System.Windows.Forms.Button();
            this.ansB = new System.Windows.Forms.Button();
            this.ansC = new System.Windows.Forms.Button();
            this.ansD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.countDownTimer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nextQueButton
            // 
            this.nextQueButton.Location = new System.Drawing.Point(678, 491);
            this.nextQueButton.Name = "nextQueButton";
            this.nextQueButton.Size = new System.Drawing.Size(110, 31);
            this.nextQueButton.TabIndex = 9;
            this.nextQueButton.Text = "Sonraki Soru";
            this.nextQueButton.UseVisualStyleBackColor = true;
            this.nextQueButton.Click += new System.EventHandler(this.nextQueButton_Click);
            // 
            // queText
            // 
            this.queText.AutoSize = true;
            this.queText.Location = new System.Drawing.Point(12, 12);
            this.queText.MaximumSize = new System.Drawing.Size(450, 0);
            this.queText.Name = "queText";
            this.queText.Size = new System.Drawing.Size(0, 17);
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
            this.ansA.Location = new System.Drawing.Point(468, 224);
            this.ansA.Name = "ansA";
            this.ansA.Size = new System.Drawing.Size(320, 58);
            this.ansA.TabIndex = 10;
            this.ansA.UseVisualStyleBackColor = true;
            this.ansA.Click += new System.EventHandler(this.ansA_Click);
            // 
            // ansB
            // 
            this.ansB.Location = new System.Drawing.Point(469, 288);
            this.ansB.Name = "ansB";
            this.ansB.Size = new System.Drawing.Size(319, 58);
            this.ansB.TabIndex = 11;
            this.ansB.UseVisualStyleBackColor = true;
            this.ansB.Click += new System.EventHandler(this.ansA_Click);
            // 
            // ansC
            // 
            this.ansC.Location = new System.Drawing.Point(469, 352);
            this.ansC.Name = "ansC";
            this.ansC.Size = new System.Drawing.Size(319, 58);
            this.ansC.TabIndex = 12;
            this.ansC.UseVisualStyleBackColor = true;
            this.ansC.Click += new System.EventHandler(this.ansA_Click);
            // 
            // ansD
            // 
            this.ansD.Location = new System.Drawing.Point(469, 416);
            this.ansD.Name = "ansD";
            this.ansD.Size = new System.Drawing.Size(319, 58);
            this.ansD.TabIndex = 13;
            this.ansD.UseVisualStyleBackColor = true;
            this.ansD.Click += new System.EventHandler(this.ansA_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cevabı Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cevabı Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // countDownTimer
            // 
            this.countDownTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countDownTimer.Location = new System.Drawing.Point(12, 491);
            this.countDownTimer.Name = "countDownTimer";
            this.countDownTimer.Size = new System.Drawing.Size(124, 30);
            this.countDownTimer.TabIndex = 16;
            this.countDownTimer.Text = "00:00:00";
            this.countDownTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sigma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(816, 534);
            this.Controls.Add(this.countDownTimer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ansD);
            this.Controls.Add(this.ansC);
            this.Controls.Add(this.ansB);
            this.Controls.Add(this.ansA);
            this.Controls.Add(this.nextQueButton);
            this.Controls.Add(this.queText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Sigma";
            this.Text = "Sigma";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox countDownTimer;
    }
}