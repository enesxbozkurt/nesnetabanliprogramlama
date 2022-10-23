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
    public partial class MusteriGiris : Form
    {
        public MusteriGiris()
        {
            InitializeComponent();
        }
          public static int MusteriID = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //bool musterik = false;
            //string ad = "";
            //string soyad = "";
            //Form1.conn.Open();
            //SqlCommand listele = new SqlCommand("select * from tbl_Musteri", Form1.conn);
            //SqlDataReader oku = listele.ExecuteReader();
            //while (oku.Read())
            //{
            //    if (oku["KullaniciAdi"].ToString() == textBox1.Text && oku["Sifre"].ToString() == textBox2.Text)
            //    {
            //        musterik = true;
            //        ad = oku["Adi"].ToString();
            //        soyad = oku["Soyadi"].ToString();
            //        MusteriID = Convert.ToInt32(oku["MusteriID"]);
            //    }
            //}

            //if (musterik==true)
            //{
            //    MessageBox.Show("Hoşgeldiniz Sayın " + ad+" "+soyad);
            //    Musteriİslem mstr = new Musteriİslem();
            //    mstr.ShowDialog();
            //    Form1.conn.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Kullanici Bulunamadı Lütfen Tekrar Deneyiniz Veya Yetkiliye Başvurunuz...");
            //}
            //Form1.conn.Close();
            MusteriData mustericlas = new MusteriData();
            mustericlas.MusteriLoginKontrol(textBox1.Text, textBox2.Text);
        }

        private void MusteriGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
