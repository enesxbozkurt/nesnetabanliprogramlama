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
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }

        private void musteri_Load(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            Form1.conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_musteriler", Form1.conn);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Form1.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();
            SqlCommand ekleme = new SqlCommand("insert into tbl_musteriler (musteri_adi,musteri_soyadi,musteri_adres,musteri_tel) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"+textBox4.Text+"')", Form1.conn);
            ekleme.ExecuteNonQuery();
            MessageBox.Show("Müşteri Eklendi");
            Form1.conn.Close();
        }

        public static string kadi = "";
        public static string ksifre = "";

        private void button2_Click(object sender, EventArgs e)
        {
            bool kkontrol = false;
            Form1.conn.Open();
            SqlCommand kadsifre = new SqlCommand("Select * from tbl_musteriler",Form1.conn);
            SqlDataReader koku = kadsifre.ExecuteReader();
            while (koku.Read())
            {
                if (textBox5.Text == koku["musteri_adi"].ToString()&& textBox6.Text == koku["musteri_soyadi"].ToString())
                {
                    kkontrol = true;
                }
            }
            if (kkontrol==true)
            {
                MessageBox.Show("Müşteri Var");
            }
            else
            {
                MessageBox.Show("Müşteri Yok");
            }
            Form1.conn.Close();
        }

        public static string musteri_id = "";
        public static string musteri_adi = "";
        public static string musteri_soyadi = "";
        public static string musteri_adres = "";
        public static string musteri_tel = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            musteri_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            musteri_adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            musteri_soyadi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            musteri_adres = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            musteri_tel = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            musteriguncelle musteriguncelleme = new musteriguncelle();
            musteriguncelleme.ShowDialog();
        }
    }
}
