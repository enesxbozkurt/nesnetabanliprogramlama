using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sozlu_proje_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.BackColor = Color.White;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                this.BackColor = Color.Red;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                this.ForeColor = Color.Black;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                this.ForeColor = Color.White;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                this.ForeColor = Color.Blue;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int[] sayilar = new int[100];
        private void button4_Click(object sender, EventArgs e)
        {
            

            int sayac = 0;
            Random rastgele = new Random();
            while (sayac < 100)
            {
                int randomSayi = rastgele.Next(0, 1000);
                if (sayilar.Contains(randomSayi) == false)
                {
                    sayilar[sayac] = randomSayi;
                    listBox1.Items.Add(sayilar[sayac]);
                    sayac++;
                }
            }

            int[] siraliDizi = new int[100];


            for (int i = 0; i < 100; i++)
            {
                int mevcutSayi = sayilar[i];

                for (int j = i; j < 100; j++)
                {

                    if (sayilar[i] > sayilar[j])
                    {
                        int gecici = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = gecici;
                    }
                }
            }

            for (int i = 0; i < 100; i++)
            {
                listBox2.Items.Add(sayilar[i]);
            }

            int[] teksayilar = new int[100];
            int[] ciftsayilar = new int[100];
            foreach (int sayi in sayilar)
            {
                for(int i = 0; i < 100; i++)
                {
                    if (sayilar[i] % 2 != 0)
                    {
                        teksayilar[i] = sayilar[i];
                        listBox4.Items.Add(teksayilar[i].ToString());
                    }
                    else if (sayilar[i] % 2 == 0)
                    {
                        ciftsayilar[i] = sayilar[i];
                        listBox3.Items.Add(ciftsayilar[i].ToString());
                    }

                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayiarama = Convert.ToInt32(textBox2.Text);
            for(int i = 0; i < 100; i++) 
            {
              if (sayiarama == sayilar[i])
              {
                MessageBox.Show("Sayi"+" "+i.ToString()+". Sırada" + " " +"UYARI: Sonuçlar İndekse Göre Gösteriliyor");
              }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En Küçük Eleman : "+listBox2.Items[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En Küçük Eleman : " + listBox2.Items[99]);
        }
    }
}

