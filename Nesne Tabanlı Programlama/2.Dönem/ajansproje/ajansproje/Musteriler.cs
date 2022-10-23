using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ajansproje
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            textBox1.Text = Guncelle.ad;
            textBox2.Text = Guncelle.soyad;
            textBox3.Text = Guncelle.telefon;
            textBox4.Text = Guncelle.adres;
            textBox5.Text = Guncelle.Kadi;
            textBox6.Text = Guncelle.Ksifre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1.conn.Close();
            //Form1.conn.Open();
            //SqlCommand guncelle = new SqlCommand("UPDATE tbl_Musteri SET Ad='" + textBox1.Text + "', Soyad='" + textBox2.Text + "',  Telefon = '" + textBox3.Text + "',  Adres = '" + textBox4.Text + "',  KullaniciAdi = '" + textBox5.Text + "',  KullaniciSifre = '" + textBox6.Text + "' WHERE  MusteriID = '" + Guncelle.musterid + "'", Form1.conn);
            //guncelle.ExecuteNonQuery();
            //MessageBox.Show("Müşteri Başarılı Bir Şekilde Güncellendi");
            //Form1.conn.Close();
            MusteriData mstrclas = new MusteriData();
            mstrclas.MusteriGuncelle(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text);

        }
    }
}
