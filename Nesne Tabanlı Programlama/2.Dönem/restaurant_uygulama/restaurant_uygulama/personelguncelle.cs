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
    public partial class personelguncelle : Form
    {
        public personelguncelle()
        {
            InitializeComponent();
        }

        private void personelguncelle_Load(object sender, EventArgs e)
        {
            textBox1.Text = personelislemleri.personel_adi;
            textBox2.Text = personelislemleri.personel_soyadi;
            textBox3.Text = personelislemleri.personel_adres;
            textBox4.Text = personelislemleri.personel_tel;
            textBox5.Text = personelislemleri.kullanici_adi;
            textBox6.Text = personelislemleri.kullannici_sifre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();
            SqlCommand guncelle = new SqlCommand("update tbl_personeller set personel_adi='" + textBox1.Text + "',personel_soyadi='" + textBox2.Text + "',personel_adres='" + textBox3.Text + "',personel_tel='" + textBox4.Text + "',kullanici_adi='" + textBox5.Text + "',kullanici_sifre='" + textBox6.Text + "' where personel_id_PK='" + personelislemleri.personel_id + "'", Form1.conn);
            guncelle.ExecuteNonQuery();
            this.Close();
            Form1.conn.Close();
        }
    }
}
