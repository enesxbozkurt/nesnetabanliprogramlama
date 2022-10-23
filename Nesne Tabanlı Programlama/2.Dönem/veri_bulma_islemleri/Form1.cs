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

namespace veri_bulma_islemleri
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
            
            conn.Open();


            SqlCommand kmt = new SqlCommand("SELECT * FROM tbl_calisanlar",conn);
            SqlDataReader veriler=kmt.ExecuteReader();
            while (veriler.Read())
            {
                listBox1.Items.Add(veriler["calisan_adi"].ToString());
                comboBox1.Items.Add(veriler["calisan_adi"].ToString());
                if (veriler["calisan_adi"].ToString()==textBox1.Text)
                {
                    MessageBox.Show("Aradığınız veri bulundu!!");
                }
            }
            


            conn.Close();
        }
    }
}
