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
    public partial class GorusmeGoruntule : Form
    {
        public GorusmeGoruntule()
        {
            InitializeComponent();
        }

        private void GorusmeGoruntule_Load(object sender, EventArgs e)
        {
            Form1.conn.Close();
            DataTable tablo = new DataTable();
            Form1.conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select Adi+' '+Soyadi as 'Müşteri Adı Soyadı',Ad+' '+Soyad as 'Görüşme Talep Edilen Oyuncu Adı Soyadı',İslemSaati as 'İşlem Tarihi' from tbl_Gorusme inner join tbl_Musteri on MusteriIDFK=MusteriID inner join tbl_Oyuncu on OyuncuIDFK=OyuncuID", Form1.conn);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Form1.conn.Close();
        }
    }
}
