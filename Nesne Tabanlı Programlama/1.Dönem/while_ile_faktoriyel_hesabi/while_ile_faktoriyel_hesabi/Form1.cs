using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_ile_faktoriyel_hesabi
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
            int faktoriyel = 1;
            int i = 1;
            while (i <= sayi)
            {
                faktoriyel = faktoriyel * i;
                i++;
            }
            MessageBox.Show("Girdiğiniz Sayının Faktöriyeli = "+faktoriyel.ToString());
        }
    }
}
