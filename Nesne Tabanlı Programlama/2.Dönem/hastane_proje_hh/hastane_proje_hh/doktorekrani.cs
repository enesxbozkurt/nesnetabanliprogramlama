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

namespace hastane_proje_hh
{
    public partial class doktorekrani : Form
    {
        public doktorekrani()
        {
            InitializeComponent();
        }

        void listele()
        {
            DataTable tablo = new DataTable();
            Form1.conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT adi+' '+soyadi as 'Hasta Adı Soyadı',oda_numarasi as 'Oda Numarası',giris_tarihi as 'Giriş Tarihi',personel_adi as 'Personel Adı'FROM tbl_personel_hastalar INNER JOIN tbl_personeller on personel_id_PK = personel_id_FK INNER JOIN tbl_hasta_bilgileri on hasta_id_FK = hasta_bilgileri_id",Form1.conn);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Form1.conn.Close();
        }

        private void doktorekrani_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
