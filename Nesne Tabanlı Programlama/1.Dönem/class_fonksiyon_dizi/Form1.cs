using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_fonksiyon_dizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        class ogrenciler 
        {
            public string isim;
            public string soyisim;
            public double sinav1;
            public double sinav2;
            public double ortalama;

            public void nothesapla() 
            {
                this.ortalama = (this.sinav1 + this.sinav2) / 2;
            }

            public string adsoyadyazdir() 
            {
                this.nothesapla();
                return "Öğrenci Adı : " + this.isim +" "+ "Öğrenci Soyadı : " + this.soyisim +" "+ "Ortalamanız : " + this.ortalama.ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciler ogrenci = new ogrenciler();
            ogrenci.isim = textBox1.Text;
            ogrenci.soyisim = textBox2.Text;
            ogrenci.sinav1 = Convert.ToInt32(textBox3.Text);
            ogrenci.sinav2 = Convert.ToInt32(textBox4.Text);

            double renkortalama = (ogrenci.sinav1 + ogrenci.sinav2) / 2;
            if (renkortalama < 50) this.BackColor = Color.Red;
            else this.BackColor = Color.Green;



            string mesaj = ogrenci.adsoyadyazdir();
            listBox1.Items.Add(mesaj);
        }
    }
}
