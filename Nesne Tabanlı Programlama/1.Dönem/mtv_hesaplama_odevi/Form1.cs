using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mtv_hesaplama_odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aractipi = comboBox1.Text;
            string aracyasi = comboBox2.Text;
            string aracmotorhacmi = comboBox3.Text;
            string aractesciltarihi = comboBox4.Text;
            double mtv_tutari = 0;
            if (aractipi == "Otomobil" && aracyasi == "1-3" && aracmotorhacmi == "0-1300" && aractesciltarihi == "01-01-2018'den Önce") 
            {
                mtv_tutari = 1313;
            }
            MessageBox.Show("Girdiğiniz Değerlere Göre Aracınızın MTV Tutarı : "+mtv_tutari);
        }
    }
}
