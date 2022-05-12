
namespace Sinav_Sistemi
{
    partial class ExtraSınav
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.queText = new System.Windows.Forms.Label();
            this.nextQueButton = new System.Windows.Forms.Button();
            this.ansA = new System.Windows.Forms.Button();
            this.ansB = new System.Windows.Forms.Button();
            this.ansC = new System.Windows.Forms.Button();
            this.ansD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(473, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // queText
            // 
            this.queText.AutoSize = true;
            this.queText.Location = new System.Drawing.Point(12, 12);
            this.queText.MaximumSize = new System.Drawing.Size(450, 0);
            this.queText.Name = "queText";
            this.queText.Size = new System.Drawing.Size(0, 17);
            this.queText.TabIndex = 1;
            // 
            // nextQueButton
            // 
            this.nextQueButton.Location = new System.Drawing.Point(682, 483);
            this.nextQueButton.Name = "nextQueButton";
            this.nextQueButton.Size = new System.Drawing.Size(110, 31);
            this.nextQueButton.TabIndex = 2;
            this.nextQueButton.Text = "Sonraki Soru";
            this.nextQueButton.UseVisualStyleBackColor = true;
            this.nextQueButton.Click += new System.EventHandler(this.nextQueButton_Click);
            // 
            // ansA
            // 
            this.ansA.Location = new System.Drawing.Point(473, 242);
            this.ansA.Name = "ansA";
            this.ansA.Size = new System.Drawing.Size(319, 54);
            this.ansA.TabIndex = 3;
            this.ansA.Text = "button1";
            this.ansA.UseVisualStyleBackColor = true;
            this.ansA.Click += new System.EventHandler(this.ansA_Click);
            // 
            // ansB
            // 
            this.ansB.Location = new System.Drawing.Point(473, 302);
            this.ansB.Name = "ansB";
            this.ansB.Size = new System.Drawing.Size(319, 51);
            this.ansB.TabIndex = 4;
            this.ansB.Text = "button2";
            this.ansB.UseVisualStyleBackColor = true;
            this.ansB.Click += new System.EventHandler(this.ansA_Click);
            // 
            // ansC
            // 
            this.ansC.Location = new System.Drawing.Point(473, 416);
            this.ansC.Name = "ansC";
            this.ansC.Size = new System.Drawing.Size(319, 51);
            this.ansC.TabIndex = 5;
            this.ansC.Text = "button3";
            this.ansC.UseVisualStyleBackColor = true;
            this.ansC.Click += new System.EventHandler(this.ansA_Click);
            // 
            // ansD
            // 
            this.ansD.Location = new System.Drawing.Point(473, 359);
            this.ansD.Name = "ansD";
            this.ansD.Size = new System.Drawing.Size(319, 51);
            this.ansD.TabIndex = 6;
            this.ansD.Text = "button4";
            this.ansD.UseVisualStyleBackColor = true;
            this.ansD.Click += new System.EventHandler(this.ansA_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cevabı Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExtraSınav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ansD);
            this.Controls.Add(this.ansC);
            this.Controls.Add(this.ansB);
            this.Controls.Add(this.ansA);
            this.Controls.Add(this.nextQueButton);
            this.Controls.Add(this.queText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ExtraSınav";
            this.Text = "ExtraSınav";
            this.Load += new System.EventHandler(this.ExtraSınav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label queText;
        private System.Windows.Forms.Button nextQueButton;
        private System.Windows.Forms.Button ansA;
        private System.Windows.Forms.Button ansB;
        private System.Windows.Forms.Button ansC;
        private System.Windows.Forms.Button ansD;
        private System.Windows.Forms.Button button1;
    }
}