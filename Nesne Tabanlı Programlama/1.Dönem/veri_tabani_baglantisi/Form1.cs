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

namespace veri_tabani_baglantisi
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

            conn.Open();
            SqlCommand kmt = new SqlCommand("SELECT * FROM tbl_calisanlar",conn);
            SqlDataReader veriler = kmt.ExecuteReader();
            while (veriler.Read())
            {
                MessageBox.Show("İD: "+veriler["calisan_id_PK"].ToString()+" "+"Çalışan Adı: "+" "+veriler["calisan_adi"].ToString());
            }
            conn.Close();

        }
    }
}
