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
    public partial class ÖğrenciGirişMain : Form
    {
        public ÖğrenciGirişMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExtraSınav main = new ExtraSınav();
            this.Hide();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sigma main = new Sigma();
            this.Hide();
            main.Show();
        }

        private void ÖğrenciGirişMain_Load(object sender, EventArgs e)
        {
            label1.Text = GirişEkranı.user.Ad+" "+GirişEkranı.user.Soyad;
        }
    }
}
