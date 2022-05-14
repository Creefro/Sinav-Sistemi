
namespace Sinav_Sistemi
{
    partial class GirişEkranı
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
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girisYap = new System.Windows.Forms.Button();
            this.kayitOl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.BackColor = System.Drawing.Color.Snow;
            this.kullaniciAdiTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(224, 80);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(100, 25);
            this.kullaniciAdiTextBox.TabIndex = 0;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.BackColor = System.Drawing.Color.Snow;
            this.sifreTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTextBox.Location = new System.Drawing.Point(224, 136);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(100, 25);
            this.sifreTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // girisYap
            // 
            this.girisYap.BackColor = System.Drawing.Color.Snow;
            this.girisYap.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYap.Location = new System.Drawing.Point(224, 202);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(100, 38);
            this.girisYap.TabIndex = 4;
            this.girisYap.Text = "Giriş";
            this.girisYap.UseVisualStyleBackColor = false;
            this.girisYap.Click += new System.EventHandler(this.girisYap_Click);
            // 
            // kayitOl
            // 
            this.kayitOl.BackColor = System.Drawing.Color.Snow;
            this.kayitOl.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitOl.Location = new System.Drawing.Point(78, 202);
            this.kayitOl.Name = "kayitOl";
            this.kayitOl.Size = new System.Drawing.Size(100, 38);
            this.kayitOl.TabIndex = 5;
            this.kayitOl.Text = "Kayıt Ol";
            this.kayitOl.UseVisualStyleBackColor = false;
            this.kayitOl.Click += new System.EventHandler(this.kayitOl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifremi Unuttum";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GirişEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(414, 313);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kayitOl);
            this.Controls.Add(this.girisYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Name = "GirişEkranı";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button girisYap;
        private System.Windows.Forms.Button kayitOl;
        private System.Windows.Forms.Label label3;
    }
}

