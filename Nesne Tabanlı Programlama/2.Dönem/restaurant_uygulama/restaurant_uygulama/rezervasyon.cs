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

namespace restaurant_uygulama
{
    public partial class rezervasyon : Form
    {
        public rezervasyon()
        {
            InitializeComponent();
        }

        private void rezervasyon_Load(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            Form1.conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select menu_adi as 'Menü Adı',yemek_adi as 'Yemekler',fiyat as 'Ücret' from tbl_yemek_menu inner join tbl_menu on menu_id_FK=menu_id_PK inner join tbl_yemek on yemek_id_FK=yemek_id_PK ", Form1.conn);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Form1.conn.Close();

            DataTable tablo2 = new DataTable();
            Form1.conn.Open();
            SqlDataAdapter adp2 = new SqlDataAdapter("select personel_id_PK as 'ID',personel_adi+' '+personel_soyadi as 'Adı Soyadı',personel_adres as 'Adres' from tbl_personeller", Form1.conn);
            adp2.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            Form1.conn.Close();

            DataTable tablo3 = new DataTable();
            Form1.conn.Open();
            SqlDataAdapter adp3 = new SqlDataAdapter("select musteri_id_PK as 'ID', musteri_adi+' '+musteri_soyadi as 'Adı Soyadı',musteri_adres as 'Adres' from tbl_musteriler", Form1.conn);
            adp3.Fill(tablo3);
            dataGridView3.DataSource = tablo3;
            Form1.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool personeldurum = false;
            bool musteridurum = false;
            Form1.conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_personeller",Form1.conn);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                if (oku["personel_id_PK"].ToString()==textBox5.Text)
                {
                    personeldurum = true;
                }
            }
            Form1.conn.Close();
            Form1.conn.Open();
            SqlCommand cmd2 = new SqlCommand("select * from tbl_musteriler",Form1.conn);
            SqlDataReader oku2 = cmd2.ExecuteReader();
            while (oku2.Read())
            {
                if (oku2["musteri_id_PK"].ToString()==textBox6.Text)
                {
                    musteridurum = true;
                }
            }
            Form1.conn.Close();
            if (personeldurum==true && musteridurum==true)
            {
                Form1.conn.Open();
                SqlCommand ekle = new SqlCommand("insert into tbl_rezervasyon (masa_id_FK,menu_id_FK,tarih,kisi_sayisi,personel_id_FK,musteri_id_FK) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')",Form1.conn);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Rezervasyon İşlemi Başarıyla Oluşturuldu..");
                Form1.conn.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Ve Müşteri ID Uyuşmuyor Lütfen Kontrol Ediniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            degerlendirme puan = new degerlendirme();
            puan.ShowDialog();
            this.Close();
        }
    }
}
