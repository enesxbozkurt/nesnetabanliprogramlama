using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_proje_hh
{
    public partial class hemsirekrani : Form
    {
        public hemsirekrani()
        {
            InitializeComponent();
        }

        private void hemsirekrani_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Form1.conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT hasta_bilgileri_id as 'Hasta Numarası',adi as 'Adı', soyadi as 'Soyadı',dogum_tarihi as 'Doğum Tarihi', oda_numarasi as 'Oda Numarası' FROM tbl_hasta_bilgileri", Form1.conn);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            Form1.conn.Close();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        void listele()
        {
            DataTable dtable = new DataTable();
            Form1.conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT hasta_bilgileri_id as 'Hasta Numarası',adi as 'Adı', soyadi as 'Soyadı',dogum_tarihi as 'Doğum Tarihi', oda_numarasi as 'Oda Numarası' FROM tbl_hasta_bilgileri", Form1.conn);
            adp.Fill(dtable);
            dataGridView1.DataSource = dtable;

            Form1.conn.Close();
        }

        private void veriarama(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();

            SqlCommand komut = new SqlCommand("UPDATE tbl_hasta_bilgileri SET adi='" + textBox1.Text + "', soyadi='" + textBox2.Text + "',  oda_numarasi = '" + textBox4.Text + "' WHERE  hasta_bilgileri_id = '" + textBox5.Text + "'", Form1.conn);
            komut.ExecuteNonQuery();
            Form1.conn.Close();


            listele();

            Form1.conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
