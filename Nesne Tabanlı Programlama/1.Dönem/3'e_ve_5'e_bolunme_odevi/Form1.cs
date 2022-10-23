using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_e_ve_5_e_bolunme_odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sayiyi dışardan alıp int türüne çevirdik
            int sayi = Convert.ToInt32(textBox1.Text);
            //Sayinin bölünüp bölünmediğini kontrol ettik ve yazdırdık
            if (sayi % 3 == 0 && sayi % 5 == 0)
            {
                MessageBox.Show("Giridiğiniz Sayı 3'e ve 5'e Tam Bölünür");
            }
            //Sayi sıfırdan küçük girilirse yapılacak işlemi yazdık
            else if (sayi == 0)
            {
                MessageBox.Show("Lütfen 0'dan Büyük Bir Rakam Giriniz...");

            }
            else 
            {
                MessageBox.Show("Girdiğiniz Sayı 3'e ve 5'e Tam Bölünmez!...");
            }
            
        }
    }
}
