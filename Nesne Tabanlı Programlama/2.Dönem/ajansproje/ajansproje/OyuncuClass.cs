using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ajansproje
{
    class OyuncuClass
    {
        public void OyuncuEkle(string ad,string soyad,string cinsiyet,string yas,string memleket,string telefon,string adres,string boy,string kilo)
        {
            Form1.conn.Close();
            Form1.conn.Open();
            SqlCommand ekle = new SqlCommand("insert into tbl_Oyuncu(Ad,Soyad,Cinsiyet,Yaş,Memleket,Telefon,Adres,Boy,Kilo) values('" + ad + "','" + soyad + "','" + cinsiyet + "','" + yas + "','" + memleket + "','" + telefon + "','" + adres + "','" + boy + "','" + kilo + "')", Form1.conn);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Oyuncu Başarıyla Eklendi!");
            MessageBox.Show("Oyuncu Veri Tabanına Aktarıldı Fakat Oyuncu Fotoğrafı İçin Lütfen Yöneticiye Başvurunuz", "Bilgilendirme Penceresi");
            Form1.conn.Close();
        }

        public void OyuncuGuncelle(string ad, string soyad, string cinsiyet, string yas, string memleket, string telefon, string adres, string boy, string kilo)
        {
            Form1.conn.Close();
            Form1.conn.Open();
            SqlCommand guncelle = new SqlCommand("UPDATE tbl_Oyuncu SET Ad = '" + ad + "', Soyad = '" + soyad + "', Cinsiyet = '" + cinsiyet + "', Yaş = '" + yas + "', Memleket = '" + memleket + "', Telefon = '" + telefon + "', Adres = '" + adres + "', Boy = '" + boy + "', Kilo = '" + kilo + "' WHERE  OyuncuID = '" + Guncelle.oyuncuid + "'", Form1.conn);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Oyuncu Başarılı Bir Şekilde Güncellendi!");
            Form1.conn.Close();
        }

        public void OyuncuSil(string id)
        {
            Form1.conn.Close();
            Form1.conn.Open();
            SqlCommand sil = new SqlCommand("delete from tbl_Oyuncu where OyuncuID='" + id + "'", Form1.conn);
            sil.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı");
            Form1.conn.Close();
        }
    }
}
