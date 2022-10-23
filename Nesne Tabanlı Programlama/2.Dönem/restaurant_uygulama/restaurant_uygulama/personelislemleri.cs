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
    public partial class personelislemleri : Form
    {
        public personelislemleri()
        {
            InitializeComponent();
        }

        private void personelislemleri_Load(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            Form1.conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_personeller", Form1.conn);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Form1.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();
            SqlCommand ekleme = new SqlCommand("insert into tbl_personeller (personel_adi,personel_soyadi,personel_adres,personel_tel,kullanici_adi,kullanici_sifre) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", Form1.conn);
            ekleme.ExecuteNonQuery();
            MessageBox.Show("Personel Eklendi");
            Form1.conn.Close();
        }

        public static string personel_id = "";
        public static string personel_adi = "";
        public static string personel_soyadi = "";
        public static string personel_adres = "";
        public static string personel_tel = "";
        public static string kullanici_adi = "";
        public static string kullannici_sifre = "";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            personel_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            personel_adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            personel_soyadi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            personel_adres = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            personel_tel = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kullanici_adi = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            kullannici_sifre = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            personelguncelle personelguncelleme = new personelguncelle();
            personelguncelleme.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rezervasyon rezerve = new rezervasyon();
            rezerve.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool pkontrol = false;
            Form1.conn.Open();
            SqlCommand kadsifre = new SqlCommand("Select * from tbl_musteriler", Form1.conn);
            SqlDataReader koku = kadsifre.ExecuteReader();
            while (koku.Read())
            {
                if (textBox8.Text == koku["personel_adi"].ToString() && textBox7.Text == koku["personel_soyadi"].ToString())
                {
                    pkontrol = true;
                }
            }
             Form1.conn.Close();
            if (pkontrol == true)
            {
                MessageBox.Show("Müşteri Var");
            }
            else
            {
                MessageBox.Show("Müşteri Yok");
            }
            
        }
    }
}
