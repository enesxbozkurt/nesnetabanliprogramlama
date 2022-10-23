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
    public partial class musteriguncelle : Form
    {
        public musteriguncelle()
        {
            InitializeComponent();
        }

        private void musteriguncelle_Load(object sender, EventArgs e)
        {
            textBox1.Text = musteri.musteri_adi;
            textBox2.Text = musteri.musteri_soyadi;
            textBox3.Text = musteri.musteri_adres;
            textBox4.Text = musteri.musteri_tel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();
            SqlCommand guncelle = new SqlCommand("update tbl_musteriler set musteri_adi='" + textBox1.Text + "',musteri_soyadi='" + textBox2.Text + "',musteri_adres='" + textBox3.Text + "',musteri_tel='"+textBox4.Text+"' where musteri_id_PK='" + musteri.musteri_id + "'", Form1.conn);
            guncelle.ExecuteNonQuery();
            this.Close();
            Form1.conn.Close();
        }
    }
}
