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

namespace hastane_proje_hh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_hastane;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string kullanici_tur = "";
        public static string adi = "";
        public static string soyadi = "";


        private void button1_Click(object sender, EventArgs e)
        {
            bool giriskontrol = false;
            string kad = "";
            conn.Open();
            SqlCommand giris = new SqlCommand("SELECT * FROM tbl_personeller INNER JOIN tbl_bolumler ON personel_bolum=bolum_id_PK", conn);
            SqlDataReader oku = giris.ExecuteReader();
            while (oku.Read())
            {
                if (textBox1.Text == oku["kullanici_adi"].ToString() && textBox2.Text == oku["kullanici_sifre"].ToString())
                {
                    giriskontrol = true;
                    kad = oku["kullanici_adi"].ToString();
                    kullanici_tur = oku["bolum_adi"].ToString();
                    adi = oku["personel_adi"].ToString();
                    soyadi = oku["personel_soyadi"].ToString();

                }
            }
            if (giriskontrol==true)
            {
                MessageBox.Show("Giriş Başarılı Hoşgeldiniz Sayın "+kad);
            }
            else
            {
                label4.Visible = true;
            }

         
            conn.Close();  
            if (kullanici_tur=="Doktor")
            {
                doktorekrani doktor = new doktorekrani();
                this.Hide();
                doktor.ShowDialog();
            }
            else if (kullanici_tur=="Hemşire")
            {
                hemsirekrani hemsire = new hemsirekrani();
                this.Hide();
                hemsire.ShowDialog();
            }
        }

        private void butonacma(object sender, KeyEventArgs e)
        {
            label4.Visible = false;
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                button1.Enabled = true;
                label4.Visible = false;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
