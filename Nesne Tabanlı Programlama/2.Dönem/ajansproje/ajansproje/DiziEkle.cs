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

namespace ajansproje
{
    public partial class DiziEkle : Form
    {
        public DiziEkle()
        {
            InitializeComponent();
        }

        private void DiziEkle_Load(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            Form1.conn.Close();
            Form1.conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select DiziID as 'ID',DiziAd as 'Dizi Adı',YapımcıAd as 'Yapımcı',BolumSayi as 'Bölüm',EklenmeTarih as 'Başlangıç Tarihi',Resim from tbl_Dizi", Form1.conn);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Form1.conn.Close();
        }
        public static string resim1 = "0";
        public static string resim2 = "0";
        public static string resim3 = "0";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          int dizid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (dizid == 1)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                resim1 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                pictureBox1.Visible = true;
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            }
            else if (dizid == 2)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                resim2 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                pictureBox1.Visible = true;
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[5].Value.ToString();


            }
            else if (dizid==3)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                resim3 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                pictureBox1.Visible = true;
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[5].Value.ToString();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox6.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YoneticiData.DiziEkle(textBox10.Text,textBox9.Text,textBox8.Text,textBox7.Text,textBox6.Text);
            Musteriİslem mstr = new Musteriİslem();
            mstr.ShowDialog();
        }

        private void Resim_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
