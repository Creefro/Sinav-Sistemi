
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtraSınav));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.queText = new System.Windows.Forms.Label();
            this.nextQueButton = new System.Windows.Forms.Button();
            this.ansA = new System.Windows.Forms.Button();
            this.ansB = new System.Windows.Forms.Button();
            this.ansC = new System.Windows.Forms.Button();
            this.ansD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.queText.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queText.Location = new System.Drawing.Point(12, 12);
            this.queText.MaximumSize = new System.Drawing.Size(450, 0);
            this.queText.Name = "queText";
            this.queText.Size = new System.Drawing.Size(0, 19);
            this.queText.TabIndex = 1;
            // 
            // nextQueButton
            // 
            this.nextQueButton.BackColor = System.Drawing.Color.GhostWhite;
            this.nextQueButton.Location = new System.Drawing.Point(672, 483);
            this.nextQueButton.Name = "nextQueButton";
            this.nextQueButton.Size = new System.Drawing.Size(120, 42);
            this.nextQueButton.TabIndex = 2;
            this.nextQueButton.Text = "Yeni Soru";
            this.nextQueButton.UseVisualStyleBackColor = false;
            this.nextQueButton.Click += new System.EventHandler(this.nextQueButton_Click);
            // 
            // ansA
            // 
            this.ansA.BackColor = System.Drawing.Color.Snow;
            this.ansA.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ansA.Location = new System.Drawing.Point(473, 242);
            this.ansA.Name = "ansA";
            this.ansA.Size = new System.Drawing.Size(319, 54);
            this.ansA.TabIndex = 3;
            this.ansA.UseVisualStyleBackColor = false;
            this.ansA.Click += new System.EventHandler(this.ansA_Click);
            // 
            // ansB
            // 
            this.ansB.BackColor = System.Drawing.Color.Snow;
            this.ansB.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ansB.Location = new System.Drawing.Point(473, 302);
            this.ansB.Name = "ansB";
            this.ansB.Size = new System.Drawing.Size(319, 51);
            this.ansB.TabIndex = 4;
            this.ansB.UseVisualStyleBackColor = false;
            this.ansB.Click += new System.EventHandler(this.ansA_Click);
            // 
            // ansC
            // 
            this.ansC.BackColor = System.Drawing.Color.Snow;
            this.ansC.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ansC.Location = new System.Drawing.Point(473, 416);
            this.ansC.Name = "ansC";
            this.ansC.Size = new System.Drawing.Size(319, 51);
            this.ansC.TabIndex = 5;
            this.ansC.UseVisualStyleBackColor = false;
            this.ansC.Click += new System.EventHandler(this.ansA_Click);
            // 
            // ansD
            // 
            this.ansD.BackColor = System.Drawing.Color.Snow;
            this.ansD.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ansD.Location = new System.Drawing.Point(473, 359);
            this.ansD.Name = "ansD";
            this.ansD.Size = new System.Drawing.Size(319, 51);
            this.ansD.TabIndex = 6;
            this.ansD.UseVisualStyleBackColor = false;
            this.ansD.Click += new System.EventHandler(this.ansA_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(543, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cevabı Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GhostWhite;
            this.button3.Location = new System.Drawing.Point(15, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 42);
            this.button3.TabIndex = 18;
            this.button3.Text = "Sınavı Sonlandır";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ExtraSınav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ansD);
            this.Controls.Add(this.ansC);
            this.Controls.Add(this.ansB);
            this.Controls.Add(this.ansA);
            this.Controls.Add(this.nextQueButton);
            this.Controls.Add(this.queText);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExtraSınav";
            this.Text = "Normal Sınav";
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
        private System.Windows.Forms.Button button3;
    }
}