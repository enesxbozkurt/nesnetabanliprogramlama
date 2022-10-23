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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_kullanicigiris;Integrated Security=True");
        string kadi = "";
        string ksifre = "";
        string ad = "";
        string soyad = "";
        int id = 0;

        private void menu_Load(object sender, EventArgs e)
        {
            kadi = giris.kadi;
            ksifre=giris.ksifre;
            textBox4.Text = kadi;
            textBox5.Text = ksifre;
            conn.Open();
            SqlCommand sorgula = new SqlCommand("select * from tbl_kullanici where kullanici_adi='"+kadi+"'",conn);
            SqlDataReader oku = sorgula.ExecuteReader();
            while (oku.Read())
            {
                ad = oku["ad"].ToString();
                soyad = oku["soyad"].ToString();
                id = Convert.ToInt32(oku["kullanici_id_PK"].ToString());
            }
            textBox1.Text = id.ToString();
            textBox2.Text = ad;
            textBox3.Text = soyad;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand guncelle = new SqlCommand("UPDATE tbl_kullanici set ad='"+textBox2.Text+"',soyad='"+textBox3.Text+"',kullanici_adi='"+textBox4.Text+"',kullanici_sifre='"+textBox5.Text+"'WHERE kullanici_id_PK = '"+textBox1.Text+"'",conn);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Güncellendi...");
            this.Hide();
            conn.Close();
            
        }
    }
}
