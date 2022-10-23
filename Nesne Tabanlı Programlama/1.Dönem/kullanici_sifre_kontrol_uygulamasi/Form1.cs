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

namespace kullanici_sifre_kontrol_uygulamasi
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           conn.Open();
            SqlCommand kmt = new SqlCommand("SELECT * FROM tbl_calisanlar", conn);
            SqlDataReader veriler = kmt.ExecuteReader();
            while (veriler.Read())
            {
                if (textBox1.Text == veriler["calisan_adi"].ToString() && textBox2.Text == veriler["calisan_soyadi"].ToString())
                {
                    MessageBox.Show("Başarılı Bir Şekilde Giriş Yaptınız \n Hoşgeldiniz Sayın " + textBox1.Text + " " + textBox2.Text);
                }
                else MessageBox.Show("Hatalı Veri Girişi Lütfen Kontrol Edin");
            }
            conn.Close();
        }
    }
}
