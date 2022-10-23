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

namespace sinema_uygulamasi_hh
{
    public partial class koltuksecimi : Form
    {
        public koltuksecimi()
        {
            InitializeComponent();
        }
          public static string film = "";
        private void koltuksecimi_Load(object sender, EventArgs e)
        {
            

            if (Form1.filmadi=="hizliveofkeli")
            {
                film = "Hızlı Ve Öfkeli";
            }
            else if (Form1.filmadi == "whoamı")
            {
                film = "WhoAmI";
            }

            int buttonsayisi = 50;
            int x = 30;
            int y = 35;
            int xartis = 80;
            int yartis = 80;

            for (int i = 1; i <=buttonsayisi; i++)
            {
                Button koltuklar=new Button();
                koltuklar.Name = "Koltuk " + i.ToString();
                koltuklar.Text = i.ToString() + " Numaralı Koltuk";
                koltuklar.Size = new Size(65,60);
                koltuklar.FlatStyle = FlatStyle.Flat;
                koltuklar.BackColor = Color.Green;
                koltuklar.ForeColor = Color.White;
                koltuklar.Click += Koltuklar_Click;
                koltuklar.Location = new Point(x,y);
                x = x + xartis;
                if (i%8==0)
                {
                    x = 30;
                    y = y + yartis;
                }
                groupBox1.Controls.Add(koltuklar);  
            }

            foreach (Control dolukoltuk in groupBox1.Controls)
            {
                if (dolukoltuk is Button)
                {
                    conn.Open();
                    SqlCommand komut = new SqlCommand("Select * from tbl_koltuk_film WHERE film_adi='"+film+"' AND koltuk_adi='"+dolukoltuk.Name+"'",conn);
                    SqlDataReader oku = komut.ExecuteReader();
                    if (oku.HasRows)
                    {
                        dolukoltuk.BackColor = Color.Red;
                    }
                    conn.Close();
                }
            }
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_sinema_uygulama;Integrated Security=True");
        private void Koltuklar_Click(object sender, EventArgs e)
        {
            string tiklanan = (sender as Button).Name;
            if ((sender as Button).BackColor==Color.Green)
            {
                conn.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_koltuk_film (koltuk_adi,film_adi) values('"+tiklanan+"','"+film+"')",conn);
                komut.ExecuteNonQuery();
                conn.Close();
            }

            (sender as Button).BackColor = Color.Red;
        }
    }
}
