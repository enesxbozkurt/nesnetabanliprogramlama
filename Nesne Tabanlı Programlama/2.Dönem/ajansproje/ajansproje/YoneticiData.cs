using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ajansproje
{
    class YoneticiData
    {
        public void YoneticiLoginKontrol(string kullaniciadi,string kullanicisifre)
        {
            Form1.conn.Open();
            SqlCommand listele = new SqlCommand("select * from tbl_Yonetici", Form1.conn);
            SqlDataReader oku = listele.ExecuteReader();
            while (oku.Read())
            {
                string ad = oku["Ad"].ToString();
                string soyad = oku["Soyad"].ToString();
                if (oku["KullaniciAdi"].ToString() == kullaniciadi && oku["Sifre"].ToString() == kullanicisifre)
                {
                    MessageBox.Show("Hoşgeldiniz Sayın " + ad + " " + soyad);
                    Yoneticiİslem yntc = new Yoneticiİslem();
                    yntc.ShowDialog();
                    Form1.conn.Close();
                }
                else
                {
                    MessageBox.Show("Kullanici Bulunamadı Lütfen Tekrar Deneyiniz Veya Yetkiliye Başvurunuz...");
                }
            }
            Form1.conn.Close();
        }

        public static void DiziEkle(string dad,string yad,string bsayi, string etarih,string resim)
        {
            Form1.conn.Close();
            Form1.conn.Open();
            SqlCommand ekle = new SqlCommand("insert into tbl_Dizi(DiziAd,YapımcıAd,BolumSayi,EklenmeTarih,Resim) values('"+dad+"','"+yad+"','"+bsayi+"','"+etarih+"','"+resim+"')",Form1.conn);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Dizi Eklendi Dizilerde Çıkması İçin Lütfen Yöneticiye Başvurun");
            Form1.conn.Close();
        }
    }
}
