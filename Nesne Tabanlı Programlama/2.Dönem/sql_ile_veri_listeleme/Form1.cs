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

namespace sql_ile_veri_listeleme
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
            listBox1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from tbl_mails", conn);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                listBox1.Items.Add("Mail ID:" + oku["mails_id_PK"].ToString() + " Mail: " + oku["kullanici_mails"].ToString());
            }

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_mails WHERE mails_id_PK = '" + textBox5.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_mails values('" + textBox2.Text + "')",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update tbl_mails set kullanici_mails='" + textBox4.Text + "' WHERE mails_id_PK = '" + textBox5.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
