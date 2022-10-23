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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }
        public static string kadi = "";
        public static string ksifre = "";
        private void personel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool giriskontrol = false;
            Form1.conn.Open();
            SqlCommand kadsifre = new SqlCommand("Select * from tbl_personeller", Form1.conn);
            SqlDataReader koku = kadsifre.ExecuteReader();
            while (koku.Read())
            {
                if (textBox1.Text == koku["kullanici_adi"].ToString() && textBox2.Text == koku["kullanici_sifre"].ToString())
                {
                    giriskontrol = true;
                }
                else
                {
                    giriskontrol = false;
                }
            }
            Form1.conn.Close();

            if (giriskontrol == true)
            {
                kadi = textBox1.Text;
                ksifre = textBox2.Text;
                personelislemleri pislem = new personelislemleri();
                this.Hide();
                Form1.conn.Close();
                pislem.ShowDialog();
            }
            else MessageBox.Show("Kullanıcı Bulunamadı...");
            Form1.conn.Close();
            this.Hide();
        }
    }
}
