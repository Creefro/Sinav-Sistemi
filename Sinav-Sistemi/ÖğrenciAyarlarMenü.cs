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
    public partial class ÖğrenciAyarlarMenü : Form
    {
        public static string[] degisenAralık;
        public ÖğrenciAyarlarMenü()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            func();
            ÖğrenciGirişMain öğrenciGirişMain = new ÖğrenciGirişMain();
            this.Hide();
            öğrenciGirişMain.Location = this.Location;
            öğrenciGirişMain.Show();
        }
        void func()
        {
            var buttons = getButton(groupBox1);
            var buttons1 = getButton(groupBox2);
            var buttons2 = getButton(groupBox3);
            var buttons3 = getButton(groupBox4);
            var buttons4 = getButton(groupBox5);
            degisenAralık = new string[10] { buttons.Text, numericUpDown1.Value.ToString(), buttons1.Text, numericUpDown2.Value.ToString(), buttons2.Text, numericUpDown3.Value.ToString(), buttons3.Text, numericUpDown4.Value.ToString(), buttons4.Text, numericUpDown4.Value.ToString() };
           
        }

        RadioButton getButton(GroupBox gb)
        {
            return gb.Controls.OfType<RadioButton>()
                            .FirstOrDefault(n => n.Checked);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ÖğrenciGirişMain öğrenciGirişMain = new ÖğrenciGirişMain();
            this.Hide();
            öğrenciGirişMain.Location = this.Location;
            öğrenciGirişMain.Show();
        }

        private void ÖğrenciAyarlarMenü_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            radioButton6.Checked = true;
            radioButton10.Checked = true;
            radioButton14.Checked = true;
            radioButton17.Checked = true;
        }
    }
}
