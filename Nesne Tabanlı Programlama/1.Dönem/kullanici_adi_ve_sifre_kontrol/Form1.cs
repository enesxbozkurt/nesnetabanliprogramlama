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

namespace kullanici_adi_ve_sifre_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAB5-OGRETMEN;Initial Catalog=enesbozkurt1011VT;User ID=enesbozkurt1011;Password=myfirstsql");

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = textBox1.Text;
            string sifre = textBox3.Text;
            bool kontrol = false;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_kullanici_giris", conn);
            SqlDataReader veriler = cmd.ExecuteReader();
            while (veriler.Read())
            {
                if (veriler["kullanici_giris_adi"].ToString() == kadi && veriler["kullanici_giris_sifre"].ToString() == sifre)
                {
                    kontrol = true;
                }
            }
            conn.Close();
            if (kontrol == true)
            {
                label4.Visible = label6.Visible = true;
                label4.Text = kadi;
                label6.Text = sifre;
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                label4.Visible  = label6.Visible = false;
                MessageBox.Show("kullanici veri tabanında bulunamadı");
            }
        }

    }
}
