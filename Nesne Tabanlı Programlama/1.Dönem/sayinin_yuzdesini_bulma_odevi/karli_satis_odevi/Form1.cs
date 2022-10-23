using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karli_satis_odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double urunfiyati = Convert.ToDouble(textBox1.Text);
            double kardegeri = Convert.ToDouble(textBox2.Text);
            double kartutari = urunfiyati * kardegeri / 100;
            double yenifiyat = urunfiyati + kartutari;
            MessageBox.Show("Ürünün Yeni Fiyatı : "+yenifiyat);
        }
    }
}
