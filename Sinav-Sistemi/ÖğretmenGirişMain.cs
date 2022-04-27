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
    public partial class ÖğretmenGirişMain : Form
    {
        public ÖğretmenGirişMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SınavEkle s = new SınavEkle();
            this.Hide();
            s.Show();
        }
    }
}
