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
    public partial class Ekleİslem : Form
    {
        public Ekleİslem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1.conn.Close();
            //Form1.conn.Open();
            //SqlCommand ekle = new SqlCommand("insert into tbl_Musteri(Ad,Soyad,Telefon,Adres,KullaniciAdi,Sifre) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')",Form1.conn);
            //ekle.ExecuteNonQuery();
            //MessageBox.Show("Müşteri Başarıyla Eklendi!");
            //Form1.conn.Close();

            MusteriData mclas = new MusteriData();
            mclas.MusteriEkle(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form1.conn.Close();
            //Form1.conn.Open();
            //SqlCommand ekle = new SqlCommand("insert into tbl_Oyuncu(Ad,Soyad,Cinsiyet,Yaş,Memleket,Telefon,Adres,Boy,Kilo) values('" + textBox8.Text + "','" + textBox10.Text + "','" + textBox12.Text + "','" + textBox11.Text + "','" + textBox9.Text + "','" + textBox15.Text + "','" + textBox7.Text + "','" + textBox13.Text + "','" + textBox14.Text + "')", Form1.conn);
            //ekle.ExecuteNonQuery();
            //MessageBox.Show("Oyuncu Başarıyla Eklendi!");
            //MessageBox.Show("Oyuncu Veri Tabanına Aktarıldı Fakat Oyuncu Fotoğrafı İçin Lütfen Yöneticiye Başvurunuz", "Bilgilendirme Penceresi");
            //Form1.conn.Close();
            OyuncuClass oynclas = new OyuncuClass();
            oynclas.OyuncuEkle(textBox8.Text,textBox10.Text,textBox12.Text,textBox11.Text,textBox9.Text,textBox15.Text,textBox7.Text,textBox13.Text,textBox14.Text);
        }

        private void Ekleİslem_Load(object sender, EventArgs e)
        {

        }
    }
}
