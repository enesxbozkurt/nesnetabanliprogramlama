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

namespace kullanici_giris_form_hh
{
    public partial class yenikayit : Form
    {
        public yenikayit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_kullanicigiris;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            bool kullanicikontrol=true;
            conn.Open();
            SqlCommand kullanicibul = new SqlCommand("Select kullanici_adi from tbl_kullanici",conn);
            SqlDataReader oku = kullanicibul.ExecuteReader();
            while (oku.Read()) 
            {
                if (oku["kullanici_adi"].ToString() == textBox3.Text) 
                {
                    kullanicikontrol = false;
                }
            }
            conn.Close();

            if (kullanicikontrol == true) 
            {
                conn.Open();
                SqlCommand kullaniciekle = new SqlCommand("INSERT INTO tbl_kullanici(ad,soyad,kullanici_adi,kullanici_sifre) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", conn);
                kullaniciekle.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kullanıcı Sisteme Eklendi!");
            }
            else
            {
                MessageBox.Show("!HATA! Böyle bir kullanıcı bulundu");
            }
            this.Hide();


        }
    }
}
