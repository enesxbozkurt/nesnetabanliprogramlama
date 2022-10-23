using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ajansproje
{
    class MusteriData
    {
        public void MusteriLoginKontrol(string kullaniciadi , string kullanicisifre)
        {
            bool musterik = false;
            string ad = "";
            string soyad = "";
            Form1.conn.Open();
            SqlCommand listele = new SqlCommand("select * from tbl_Musteri", Form1.conn);
            SqlDataReader oku = listele.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == kullaniciadi && oku["Sifre"].ToString() == kullanicisifre)
                {
                    musterik = true;
                    ad = oku["Adi"].ToString();
                    soyad = oku["Soyadi"].ToString();
                    MusteriGiris.MusteriID = Convert.ToInt32(oku["MusteriID"]);
                }
            }

            if (musterik == true)
            {
                MessageBox.Show("Hoşgeldiniz Sayın " + ad + " " + soyad);
                Musteriİslem mstr = new Musteriİslem();
                mstr.ShowDialog();
                Form1.conn.Close();
            }
            else
            {
                MessageBox.Show("Kullanici Bulunamadı Lütfen Tekrar Deneyiniz Veya Yetkiliye Başvurunuz...");
            }
            Form1.conn.Close();
        }
        public void MusteriEkle(string ad,string soyad,string telefon,string adres,string kullaniciadi,string sifre)
        {
            Form1.conn.Close();
            Form1.conn.Open();
            SqlCommand ekle = new SqlCommand("insert into tbl_Musteri(Adi,Soyadi,Telefon,Adres,KullaniciAdi,Sifre) values('" + ad + "','" + soyad + "','" + telefon + "','" + adres + "','" + kullaniciadi + "','" + sifre + "')", Form1.conn);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Müşteri Başarıyla Eklendi!");
            Form1.conn.Close();
        }

      public void MusteriGuncelle(string ad,string soyad,string tel,string adres,string kadi,string sifre)    
          {
            Form1.conn.Close();
            Form1.conn.Open();
            SqlCommand guncelle = new SqlCommand("UPDATE tbl_Musteri SET Adi='" + ad + "', Soyadi='" + soyad + "',  Telefon = '" + tel + "',  Adres = '" + adres + "',  KullaniciAdi = '" + kadi + "',  Sifre = '" + sifre + "' WHERE  MusteriID = '" + Guncelle.musterid + "'", Form1.conn);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Müşteri Başarılı Bir Şekilde Güncellendi");
            Form1.conn.Close();
        }
        public void MusteriSil(string id)
        {
            Form1.conn.Close();
            Form1.conn.Open();
            SqlCommand sil = new SqlCommand("delete from tbl_Musteri where MusteriID='" + id + "'", Form1.conn);
            sil.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı");
            Form1.conn.Close();
        }
    }
}
