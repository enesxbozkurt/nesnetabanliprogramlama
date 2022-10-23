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
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form1.conn.Open();
            //SqlCommand listele = new SqlCommand("select * from tbl_Yonetici",Form1.conn);
            //SqlDataReader oku = listele.ExecuteReader();
            //while (oku.Read())
            //{
            //    string ad = oku["Ad"].ToString();
            //    string soyad = oku["Soyad"].ToString();
            //    if (oku["KullaniciAdi"].ToString()==textBox1.Text&&oku["Sifre"].ToString()==textBox2.Text)
            //    {
            //        MessageBox.Show("Hoşgeldiniz Sayın "+ad+" "+soyad);
            //        Yoneticiİslem yntc = new Yoneticiİslem();
            //        yntc.ShowDialog();
            //        Form1.conn.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Kullanici Bulunamadı Lütfen Tekrar Deneyiniz Veya Yetkiliye Başvurunuz...");
            //    }
            //}
            //Form1.conn.Close();
            YoneticiData yoneticiclas = new YoneticiData();
            yoneticiclas.YoneticiLoginKontrol(textBox1.Text,textBox2.Text);
        }

        private void YoneticiGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
