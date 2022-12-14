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
    public partial class Hafsanur : Form
    {
        public Hafsanur()
        {
            InitializeComponent();
        }

        int ID = 3;
        string Ad = "";
        string Soyad = "";
        string Cinsiyet = "";
        string Yas = "";
        string Memleket = "";
        string Telefon = "";
        string Adres = "";
        string Boy = "";
        string Kilo = "";

        private void Hafsanur_Load(object sender, EventArgs e)
        {
            Form1.conn.Close();
            Form1.conn.Open();
            SqlCommand listele = new SqlCommand("select * from tbl_Oyuncu where OyuncuID='" + ID + "'", Form1.conn);
            SqlDataReader oku = listele.ExecuteReader();
            while (oku.Read())
            {
                Ad = oku["Ad"].ToString();
                Soyad = oku["Soyad"].ToString();
                Cinsiyet = oku["Cinsiyet"].ToString();
                Yas = oku["Yaş"].ToString();
                Memleket = oku["Memleket"].ToString();
                Telefon = oku["Telefon"].ToString();
                Adres = oku["Adres"].ToString();
                Boy = oku["Boy"].ToString();
                Kilo = oku["Kilo"].ToString();
            }
            Form1.conn.Close();
            textBox1.Text = Ad;
            textBox2.Text = Soyad;
            textBox3.Text = Cinsiyet;
            textBox4.Text = Yas;
            textBox5.Text = Memleket;
            textBox6.Text = Telefon;
            textBox7.Text = Adres;
            textBox8.Text = Boy;
            textBox9.Text = Kilo;
            if (Guncelle.kontrol == true)
            {
                button1.Visible = false;
                button2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();
            SqlCommand ekle = new SqlCommand("insert into tbl_Gorusme(MusteriIDFK,OyuncuIDFK) values('" + MusteriGiris.MusteriID + "','" + ID + "')", Form1.conn);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Görüşme Talebiniz Alınmıştır!");
            Form1.conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form1.conn.Close();
            //Form1.conn.Open();
            //SqlCommand guncelle = new SqlCommand("UPDATE tbl_Oyuncu SET Ad = '" + textBox1.Text + "', Soyad = '" + textBox2.Text + "', Cinsiyet = '" + textBox3.Text + "', Yaş = '" + textBox4.Text + "', Memleket = '" + textBox5.Text + "', Telefon = '" + textBox6.Text + "', Adres = '" + textBox7.Text + "', Boy = '" + textBox8.Text + "', Kilo = '" + textBox9.Text + "' WHERE  OyuncuID = '" + Guncelle.oyuncuid + "'", Form1.conn);
            //guncelle.ExecuteNonQuery();
            //MessageBox.Show("Oyuncu Başarılı Bir Şekilde Güncellendi!");
            //Form1.conn.Close();
            OyuncuClass oynclas = new OyuncuClass();
            oynclas.OyuncuGuncelle(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
        }
    }
}
