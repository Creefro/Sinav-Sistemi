
namespace Sinav_Sistemi
{
    partial class ÖğrenciGirişMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖğrenciGirişMain));
            this.extraButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.sigmaButton = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.exitPic = new System.Windows.Forms.PictureBox();
            this.settingsPic = new System.Windows.Forms.PictureBox();
            this.pfpPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpPic)).BeginInit();
            this.SuspendLayout();
            // 
            // extraButton
            // 
            this.extraButton.BackColor = System.Drawing.Color.Snow;
            this.extraButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.extraButton.Location = new System.Drawing.Point(58, 189);
            this.extraButton.Name = "extraButton";
            this.extraButton.Size = new System.Drawing.Size(214, 89);
            this.extraButton.TabIndex = 0;
            this.extraButton.Text = "          Extra Sınav Ol";
            this.extraButton.UseVisualStyleBackColor = false;
            this.extraButton.Click += new System.EventHandler(this.extraButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(423, 71);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(661, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "asd";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sigmaButton
            // 
            this.sigmaButton.BackColor = System.Drawing.Color.Snow;
            this.sigmaButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sigmaButton.Location = new System.Drawing.Point(58, 71);
            this.sigmaButton.Name = "sigmaButton";
            this.sigmaButton.Size = new System.Drawing.Size(214, 89);
            this.sigmaButton.TabIndex = 1;
            this.sigmaButton.Text = "            SIGMA Sınav Ol";
            this.sigmaButton.UseVisualStyleBackColor = false;
            this.sigmaButton.Click += new System.EventHandler(this.sigmaButton_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Sinav_Sistemi.Properties.Resources.exam;
            this.pictureBox5.Location = new System.Drawing.Point(74, 212);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sinav_Sistemi.Properties.Resources.halloween;
            this.pictureBox4.Location = new System.Drawing.Point(74, 94);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // exitPic
            // 
            this.exitPic.Image = global::Sinav_Sistemi.Properties.Resources.exit;
            this.exitPic.Location = new System.Drawing.Point(12, 323);
            this.exitPic.Name = "exitPic";
            this.exitPic.Size = new System.Drawing.Size(57, 52);
            this.exitPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitPic.TabIndex = 9;
            this.exitPic.TabStop = false;
            this.exitPic.Click += new System.EventHandler(this.exit_Click);
            // 
            // settingsPic
            // 
            this.settingsPic.Image = global::Sinav_Sistemi.Properties.Resources.setting;
            this.settingsPic.Location = new System.Drawing.Point(686, 323);
            this.settingsPic.Name = "settingsPic";
            this.settingsPic.Size = new System.Drawing.Size(54, 50);
            this.settingsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsPic.TabIndex = 8;
            this.settingsPic.TabStop = false;
            this.settingsPic.Click += new System.EventHandler(this.settings_Click);
            // 
            // pfpPic
            // 
            this.pfpPic.Image = global::Sinav_Sistemi.Properties.Resources.user;
            this.pfpPic.Location = new System.Drawing.Point(620, 14);
            this.pfpPic.Name = "pfpPic";
            this.pfpPic.Size = new System.Drawing.Size(35, 33);
            this.pfpPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfpPic.TabIndex = 7;
            this.pfpPic.TabStop = false;
            // 
            // ÖğrenciGirişMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(752, 385);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.exitPic);
            this.Controls.Add(this.settingsPic);
            this.Controls.Add(this.pfpPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.sigmaButton);
            this.Controls.Add(this.extraButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ÖğrenciGirişMain";
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.ÖğrenciGirişMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button extraButton;
        private System.Windows.Forms.Button sigmaButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pfpPic;
        private System.Windows.Forms.PictureBox settingsPic;
        private System.Windows.Forms.PictureBox exitPic;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}