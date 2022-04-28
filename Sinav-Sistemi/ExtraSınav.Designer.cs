
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
            this.ansA = new System.Windows.Forms.Label();
            this.ansB = new System.Windows.Forms.Label();
            this.ansC = new System.Windows.Forms.Label();
            this.ansD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(473, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 206);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // queText
            // 
            this.queText.AutoSize = true;
            this.queText.Location = new System.Drawing.Point(12, 12);
            this.queText.MaximumSize = new System.Drawing.Size(450, 0);
            this.queText.Name = "queText";
            this.queText.Size = new System.Drawing.Size(104, 17);
            this.queText.TabIndex = 1;
            this.queText.Text = "soru goes here";
            // 
            // nextQueButton
            // 
            this.nextQueButton.Location = new System.Drawing.Point(713, 407);
            this.nextQueButton.Name = "nextQueButton";
            this.nextQueButton.Size = new System.Drawing.Size(75, 31);
            this.nextQueButton.TabIndex = 2;
            this.nextQueButton.Text = "Next";
            this.nextQueButton.UseVisualStyleBackColor = true;
            this.nextQueButton.Click += new System.EventHandler(this.nextQueButton_Click);
            // 
            // ansA
            // 
            this.ansA.AutoSize = true;
            this.ansA.Location = new System.Drawing.Point(12, 263);
            this.ansA.Name = "ansA";
            this.ansA.Size = new System.Drawing.Size(22, 17);
            this.ansA.TabIndex = 3;
            this.ansA.Tag = "1";
            this.ansA.Text = "A)";
            // 
            // ansB
            // 
            this.ansB.AutoSize = true;
            this.ansB.Location = new System.Drawing.Point(392, 263);
            this.ansB.Name = "ansB";
            this.ansB.Size = new System.Drawing.Size(22, 17);
            this.ansB.TabIndex = 4;
            this.ansB.Tag = "2";
            this.ansB.Text = "B)";
            // 
            // ansC
            // 
            this.ansC.AutoSize = true;
            this.ansC.Location = new System.Drawing.Point(12, 349);
            this.ansC.Name = "ansC";
            this.ansC.Size = new System.Drawing.Size(22, 17);
            this.ansC.TabIndex = 5;
            this.ansC.Tag = "3";
            this.ansC.Text = "C)";
            // 
            // ansD
            // 
            this.ansD.AutoSize = true;
            this.ansD.Location = new System.Drawing.Point(392, 349);
            this.ansD.Name = "ansD";
            this.ansD.Size = new System.Drawing.Size(23, 17);
            this.ansD.TabIndex = 6;
            this.ansD.Tag = "4";
            this.ansD.Text = "D)";
            // 
            // ExtraSınav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Label ansA;
        private System.Windows.Forms.Label ansB;
        private System.Windows.Forms.Label ansC;
        private System.Windows.Forms.Label ansD;
    }
}