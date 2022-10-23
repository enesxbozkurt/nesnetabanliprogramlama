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
    public partial class degerlendirme : Form
    {
        public degerlendirme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.conn.Open();
            SqlCommand ekle = new SqlCommand("insert into tbl_degerlendirme (rezervasyon_id_FK,musteri_id_FK,puan) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')",Form1.conn);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Değerlendirme Gönderildi..");
            Form1.conn.Close();
        }
    }
}
