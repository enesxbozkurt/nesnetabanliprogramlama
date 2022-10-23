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

namespace personel_proje_hh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_kullanicigiris;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            bool kullanicigiris = false;
            bool kullaniciyetki = false;
            conn.Open();
            SqlCommand kmt = new SqlCommand("SELECT * FROM tbl_kullanici",conn);
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                if(oku["kullanici_adi"].ToString()==textBox1.Text&& oku["kullanici_sifre"].ToString() == textBox2.Text)
                {
                    kullanicigiris = true;
                    kullaniciyetki = Convert.ToBoolean(oku["kullanici_yetki"]);

                }
              
            }

            if (kullanicigiris == true)
            {

                if (kullaniciyetki == true)
                {
                    admin_panel admn = new admin_panel();
                    this.Hide();
                    admn.ShowDialog();
                }
                else
                {
                    kullanici_ekrani klnc = new kullanici_ekrani();
                    this.Hide();
                    klnc.ShowDialog();
                }
            }
            else 
            { 
            //hatalı
            
            
            }
 

            conn.Close();
        }
    }
}
