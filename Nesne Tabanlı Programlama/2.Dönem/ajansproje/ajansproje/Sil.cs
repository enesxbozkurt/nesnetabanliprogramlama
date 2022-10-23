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
    public partial class Sil : Form
    {
        public Sil()
        {
            InitializeComponent();
        }

        private void Sil_Load(object sender, EventArgs e)
        {
            DataTable dtable = new DataTable();
            Form1.conn.Close();
            Form1.conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select MusteriID as 'Müşteri İd',Adi as 'Müşteri Adı',Soyadi as 'Müşteri Soyadı',Telefon as 'Telefon Numarası',Adres,KullaniciAdi,Sifre from tbl_Musteri", Form1.conn);
            adp.Fill(dtable);
            dataGridView1.DataSource = dtable;
            Form1.conn.Close();

            DataTable tablo = new DataTable();
            Form1.conn.Close();
            Form1.conn.Open();
            SqlDataAdapter adp2 = new SqlDataAdapter("select * from tbl_Oyuncu", Form1.conn);
            adp2.Fill(tablo);
            dataGridView2.DataSource = tablo;
            Form1.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1.conn.Close();
            //Form1.conn.Open();
            //SqlCommand sil = new SqlCommand("delete from tbl_Musteri where MusteriID='"+textBox1.Text+"'",Form1.conn);
            //sil.ExecuteNonQuery();
            //MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı");
            //Form1.conn.Close();
            MusteriData mstrclas = new MusteriData();
            mstrclas.MusteriSil(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form1.conn.Close();
            //Form1.conn.Open();
            //SqlCommand sil = new SqlCommand("delete from tbl_Oyuncu where OyuncuID='" + textBox2.Text + "'", Form1.conn);
            //sil.ExecuteNonQuery();
            //MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı");
            //Form1.conn.Close();
            OyuncuClass oynclas = new OyuncuClass();
            oynclas.OyuncuSil(textBox2.Text);
        }
    }
}
