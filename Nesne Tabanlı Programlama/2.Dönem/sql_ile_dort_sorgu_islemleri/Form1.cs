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


namespace sql_ile_dort_sorgu_islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAB5-OGRETMEN;Initial Catalog=enesbozkurt1011VT;User ID=enesbozkurt1011;Password=myfirstsql");

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand listele = new SqlCommand("select * from kullanicilar", conn);
            SqlDataReader oku = listele.ExecuteReader();
            while (oku.Read())
            {
                string kullanicilar = "Adı:" + oku["adi"].ToString() + " "+"Soyadı:" + oku["soyadi"].ToString() + " Kullanıcı Adı:" + oku["kullanici_adi"].ToString();
                listBox1.Items.Add(kullanicilar);
            }
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            conn.Open();
            SqlCommand ekleSorgusu = new SqlCommand("insert into kullanicilar(adi,soyadi,kullanici_adi,kullanici_sifre) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", conn);
            ekleSorgusu.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kullanıcı Eklendi");
            conn.Open();
            SqlCommand listelemeislemi = new SqlCommand("select * from kullanicilar", conn);
            SqlDataReader oku = listelemeislemi.ExecuteReader();
            while (oku.Read())
            {
                string kullanicilar = "Adı:" + oku["adi"].ToString() + " " + "Soyadı:" + oku["soyadi"].ToString() + " Kullanıcı Adı:" + oku["kullanici_adi"].ToString();
                listBox1.Items.Add(kullanicilar);
            }
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand guncelle = new SqlCommand("update kullanicilar set adi = '" + textBox8.Text + "', soyadi='" + textBox7.Text + "', kullanici_sifre = '" + textBox5.Text + "' WHERE kullanici_adi = '" + textBox6.Text + "'", conn);
            guncelle.ExecuteNonQuery();
            conn.Close();
            listBox1.Items.Clear();
            conn.Open();
            SqlCommand listelemeislemi = new SqlCommand("select * from kullanicilar", conn);
            SqlDataReader oku = listelemeislemi.ExecuteReader();
            while (oku.Read())
            {
                string kullanicilar = "Adı:" + oku["adi"].ToString() + " " + "Soyadı:" + oku["soyadi"].ToString() + " Kullanıcı Adı:" + oku["kullanici_adi"].ToString();
                listBox1.Items.Add(kullanicilar);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sil = new SqlCommand("delete from kullanicilar where kullanici_adi = '" + textBox10.Text + "'", conn);
            sil.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kullanıcı Silindi");
            listBox1.Items.Clear();
            conn.Open();
            SqlCommand listelemeislemi = new SqlCommand("select * from kullanicilar", conn);
            SqlDataReader oku = listelemeislemi.ExecuteReader();
            while (oku.Read())
            {
                string kullanicilar = "Adı:" + oku["adi"].ToString() + " " + "Soyadı:" + oku["soyadi"].ToString() + " Kullanıcı Adı:" + oku["kullanici_adi"].ToString();
                listBox1.Items.Add(kullanicilar);
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            conn.Open();
            SqlCommand ozelliste = new SqlCommand("select * from kullanicilar where kullanici_adi = '" + textBox9.Text + "'", conn);
            SqlDataReader oku = ozelliste.ExecuteReader();

            while (oku.Read())
            {
                string kullanicilar = "Adı:" + oku["adi"].ToString() + " " + "Soyadı:" + oku["soyadi"].ToString() + " Kullanıcı Adı:" + oku["kullanici_adi"].ToString();
                listBox1.Items.Add(kullanicilar);
            }

            conn.Close();
        }
    }
}
