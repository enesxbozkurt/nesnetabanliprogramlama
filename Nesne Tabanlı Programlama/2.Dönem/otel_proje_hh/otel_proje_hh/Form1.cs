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


namespace otel_proje_hh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_otel;Integrated Security=True");


        //oda_kayit kayit = new oda_kayit
        public static string secilioda="";

        
        private void Form1_Load(object sender, EventArgs e)
        {
            int butonsayac = 16;
            foreach (Control x in this.Controls)
            {
                if (x is Button)
                {
                    x.Text = "Oda " + butonsayac.ToString();
                    x.BackColor = Color.DarkGreen;
                    x.ForeColor = Color.White;

                    conn.Open();
                    SqlCommand listele = new SqlCommand("SELECT * FROM tbl_musteriler",conn);
                    SqlDataReader oku = listele.ExecuteReader();
                    while (oku.Read())
                    {
                        if (oku["oda_numarasi"].ToString()==x.Text)
                        {
                            x.BackColor = Color.Red;    
                        }
                    }
                    conn.Close();

                    butonsayac--;
                }
            }
        }

        private void oda_sec(object sender, EventArgs e)
        {

            secilioda = (sender as Button).Text.ToString();
            if ((sender as Button).BackColor==Color.Red)
            {
             MessageBox.Show("Oda Dolu!!!");
                /*
           else
           {
               oda_kayit kayit = new oda_kayit();
               kayit.ShowDialog();
           }

           if (oda_kayit.odadurum==true)
           {
               (sender as Button).BackColor = Color.Red;
           }*/
                oda_kayit kayit = new oda_kayit();
                kayit.ShowDialog();
            }
           
            else
            {
                oda_kayit kayit = new oda_kayit();
                kayit.ShowDialog();
                if (oda_kayit.odadurum==true)
                {
                    (sender as Button).BackColor = Color.Red;
                }
            }

        }
    }
}
