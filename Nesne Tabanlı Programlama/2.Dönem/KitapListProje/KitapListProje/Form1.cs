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

namespace KitapListProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=denemebaglanti;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            List<Kitap> Kitaplar = new List<Kitap>();
            SqlCommand listele = new SqlCommand("select * from tbl_Kitaplar",conn);
            SqlDataReader oku = listele.ExecuteReader();
            Kitap kitap1 = new Kitap();
            while (oku.Read())
            {
                kitap1.KitapID = Convert.ToInt32(oku["KitapID"]);
                kitap1.KitapAd = oku["KitapAd"].ToString();
                kitap1.KitapYazarID = Convert.ToInt32(oku["KitapYazarID"]);
                kitap1.KitapSayfaSayi = Convert.ToInt32(oku["KitapSayfaSayi"]);
                Kitaplar.Add(kitap1);
            }
            conn.Close();
            dataGridView1.DataSource = Kitaplar;
        }
    }
}
