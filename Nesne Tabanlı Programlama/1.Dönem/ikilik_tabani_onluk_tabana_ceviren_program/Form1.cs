using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikilik_tabani_onluk_tabana_ceviren_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ikiliksayi = textBox1.Text;
            double onluksayi = 0;
            for(int i = 0; i < ikiliksayi.Length; i++)
            {
                onluksayi = onluksayi + Math.Pow(2, i);
            }
            MessageBox.Show("Sayınızın 10'luk Tabandaki Karşılığı: "+onluksayi.ToString());
        }
    }
}
