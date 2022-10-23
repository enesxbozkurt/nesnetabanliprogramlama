using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sekillerin_alanları_odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int karekenar = Convert.ToInt32(textBox1.Text);
            double karealan = karekenar * karekenar;
            label2.Text = karealan.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dikdortgen1 = Convert.ToInt32(textBox2.Text);
            int dikdortgen2 = Convert.ToInt32(textBox3.Text);
            double dikdortgenalan = dikdortgen1 * dikdortgen2;
            label5.Text = dikdortgenalan.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dikucgentaban = Convert.ToDouble(textBox4.Text);
            double dikucgenyukseklik = Convert.ToDouble(textBox5.Text);
            double dikucgenalan = (dikucgentaban * dikucgenyukseklik) / 2;
            label8.Text = dikucgenalan.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double birkenar = Convert.ToDouble(textBox6.Text);
            double ikikenar = Convert.ToDouble(textBox7.Text);
            double uckenar = Convert.ToDouble(textBox8.Text);
            double kenaralan = (birkenar + ikikenar + uckenar) / 2;
            label12.Text = kenaralan.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double daireyaricap = Convert.ToDouble(textBox9.Text);
            double dairealan = (daireyaricap * daireyaricap) * 3.14;
            label14.Text = dairealan.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox10.Text);
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            label16.Text = faktoriyel.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double sicaklik = Convert.ToDouble(textBox11.Text);
            double fahrenheit = (sicaklik * (9 / 5)) + 32;
            label18.Text = fahrenheit.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox12.Text);
            double s = 0.75;
            double toplam = a * a * (Math.Sqrt(s));
            label19.Text = toplam.ToString();

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
    }
}
