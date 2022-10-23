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

namespace kullanici_odev_17022022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_kullanicigiris;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        public static int id = 0;
        public static string ad = "";
        public static string soyad = "";
        public static string telefon_no = "";
        public static string araba_markasi = "";
        public static string ilce = "";
        public static string kadi = "";
        public static string ksifre = "";

        private void button1_Click(object sender, EventArgs e)
        {
            bool giriskontrol = false;
            conn.Open();
            SqlCommand kbul = new SqlCommand("Select * from tbl_kullanici_bilgisi where kullanici_adi='"+textBox1.Text+"'", conn);
            SqlDataReader koku = kbul.ExecuteReader();
            while (koku.Read())
            {
                if (textBox1.Text == koku["kullanici_adi"].ToString() && textBox2.Text == koku["kullanici_sifre"].ToString())
                {
                    giriskontrol = true;
                }
            }

            if (giriskontrol == true)
            {
                id = Convert.ToInt32(koku["kullanici_bilgisi_id_PK"].ToString());
                kadi = textBox1.Text;
                ksifre = textBox2.Text;
                ad = koku["ad"].ToString();
                soyad = koku["soyad"].ToString();
                telefon_no = koku["telefon_numarasi"].ToString();
                araba_markasi = koku["araba_markasi"].ToString();
                ilce = koku["ilce"].ToString();
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
