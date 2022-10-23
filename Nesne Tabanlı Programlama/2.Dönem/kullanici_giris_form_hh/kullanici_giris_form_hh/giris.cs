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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_kullanicigiris;Integrated Security=True");

        public static string kadi = "";
        public static string ksifre = "";
        private void button1_Click(object sender, EventArgs e)
        {
            bool giriskontrol = false;
            conn.Open();
            SqlCommand kadsifre = new SqlCommand("Select kullanici_adi,kullanici_sifre from tbl_kullanici",conn);
            SqlDataReader koku = kadsifre.ExecuteReader();
            while (koku.Read()) 
            {
                if (textBox1.Text == koku["kullanici_adi"].ToString()&& textBox2.Text == koku["kullanici_sifre"].ToString())
                {
                    giriskontrol = true;
                }
            }

            if (giriskontrol == true)
            {
                kadi = textBox1.Text;
                ksifre = textBox2.Text;
                menu form = new menu();
                this.Hide();
                form.Show();
            }
            else MessageBox.Show("Kullanıcı Bulunamadı...");
            conn.Close();
            this.Hide();

        }
    }
}
