using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayinin_yuzdesini_bulma_odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            double yuzdesayisi = Convert.ToDouble(textBox2.Text);
            double yenisayi = sayi*yuzdesayisi/100;
            MessageBox.Show("Girilen Sayının Girdiğiniz Yüzdesi : "+yenisayi);
        }
    }
}
