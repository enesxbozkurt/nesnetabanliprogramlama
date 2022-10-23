using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelimedeki_sessiz_harfi_bulma_odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = textBox1.Text;
            string sessizharfler = "ncçdgğjhklmrnpsştvyz";
            int sessizharfsayisi = 0;
            for (int i = 0; i < kelime.Length;i++)
            {
                string harf = kelime[i].ToString();
                if (sessizharfler.Contains(harf)) 
                {
                    sessizharfsayisi++;
                }
            }
            MessageBox.Show("Yazdığınız Kelimede Bulunan Sessiz Harf Sayısı : " + sessizharfsayisi);
        }
    }
}
