using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_yapısı_hh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Dikdortgen
        {
            private int sayi1, sayi2;

            public Dikdortgen(int a,int b)
            {
                this.sayi1 = a;
                this.sayi2 = b;
            }

            public int AlanHesapla()
            {
                return this.sayi1 * this.sayi2;
            }

            public int CevreHesapla()
            {
                return 2 * (this.sayi1 + this.sayi2);
            }

        }

        class Dikdortgen2
        {
            public int sayi1, sayi2;

            public int AlanHesapla2()
            {
                return this.sayi1 * this.sayi2;
            }

            public int CevreHesapla2()
            {
                return 2 * (this.sayi1 + this.sayi2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dikdortgen DikdortgenClass=new Dikdortgen(10,20);
            int DikdortgenAlanı = DikdortgenClass.AlanHesapla();
            int DikdortgenCevresi = DikdortgenClass.CevreHesapla();
            MessageBox.Show("Dikdortgen Alanı : "+DikdortgenAlanı.ToString()+"\n Dikdörtgen Çevresi: "+DikdortgenCevresi.ToString());

            Dikdortgen2 DikdortgenClass2 = new Dikdortgen2();
            DikdortgenClass2.sayi1 = 30;
            DikdortgenClass2.sayi2 = 40;
            int DikdortgenAlanı2 = DikdortgenClass2.AlanHesapla2();
            int DikdortgenCevresi2 = DikdortgenClass2.CevreHesapla2();
            MessageBox.Show("Dikdortgen Alanı : " + DikdortgenAlanı2.ToString() + "\n Dikdörtgen Çevresi: " + DikdortgenCevresi2.ToString());
        }
    }
}
