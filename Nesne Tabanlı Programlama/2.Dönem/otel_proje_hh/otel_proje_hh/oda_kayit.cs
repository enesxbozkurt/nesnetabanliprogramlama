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

namespace otel_proje_hh
{
    public partial class oda_kayit : Form
    {
        public oda_kayit()
        {
            InitializeComponent();
        }
        public static bool odadurum = false;
        public static bool kayitdurum = false;
        private void button1_Click(object sender, EventArgs e)
        {
            bool bosVeriVarMi = false;
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    if (x.Text.Length == 0)
                    {
                        bosVeriVarMi = true;
                    }
                }
            }

            if (bosVeriVarMi == true)
            {
                MessageBox.Show("Boş Alan Olamaz.");
            }
            else
            {
                Form1.conn.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO tbl_musteriler(oda_numarasi,musteri_adi,musteri_soyadi,musteri_tel,musteri_tc) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", Form1.conn);
                komut.ExecuteNonQuery();
                Form1.conn.Close();
                odadurum = true;

                MessageBox.Show("Yeni Kayıt Başarılı Bir Şekilde Gerçekleşti");
                this.Close();
            }
        }

        private void oda_kayit_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.secilioda;
            Form1.conn.Open();
            SqlCommand listele = new SqlCommand("select*from tbl_musteriler",Form1.conn);
            SqlDataReader oku = listele.ExecuteReader();
            while (oku.Read())
            {
                if (oku["oda_numarasi"].ToString()==textBox1.Text)
                {
                    textBox2.Text = oku["musteri_adi"].ToString();
                    textBox3.Text = oku["musteri_soyadi"].ToString();
                    textBox4.Text = oku["musteri_tel"].ToString();
                    textBox5.Text = oku["musteri_tc"].ToString();
                    kayitdurum = true;
                    button1.Visible = true;
                }
            }
            Form1.conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();
            SqlCommand silmeislemi = new SqlCommand("Delete from tbl_musteriler where oda_numarasi='"+textBox1.Text+"'",Form1.conn);
            silmeislemi.ExecuteNonQuery();  
            Form1.conn.Close();
        }
    }
}
