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

namespace buton_calismasi_21032022
{
    public partial class koltuksec : Form
    {
        public koltuksec()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAB5-OGRETMEN;Initial Catalog=enesbozkurt1011VT;User ID=enesbozkurt1011;Password=myfirstsql");
        string film = "";

        private void koltuksec_Load(object sender, EventArgs e)
        {
            if (Form1.filmadi == "hizliveofkeli")
            {
                film = "Hızlı Ve Öfkeli";
            }
            else if (Form1.filmadi == "ibo")
            {
                film = "İbrahim Tatlıses";
            }
            else if (Form1.filmadi == "spiderman")
            {
                film = "Spiderman";
            }
            else if (Form1.filmadi == "spiderman2")
            {
                film = "Spiderman2";
            }
            


            int butonsayisi = 100;
            int x = 30;
            int y = 35;
            int xartis = 80;
            int yartis = 80;

            for (int i = 1; i <= butonsayisi; i++)
            {
                Button koltuklar=new Button();
                koltuklar.Name = "Koltuk" + i.ToString();
                koltuklar.Text = i.ToString() + "Numaralı Koltuk";
                koltuklar.Size = new Size(65,60);
                koltuklar.FlatStyle = FlatStyle.Flat;
                koltuklar.BackColor = Color.Green;
                koltuklar.ForeColor = Color.White;

                koltuklar.Click += koltuklar_Click;

                koltuklar.Location = new Point(x, y);
                x = x + xartis;

                if (i % 8 == 0) 
                {
                    x = 30;
                    y = y + yartis;
                }

                groupBox1.Controls.Add(koltuklar);

            }

            foreach (Control dolukoltuklar in groupBox1.Controls)
            {
                if (dolukoltuklar is Button)
                {
                    conn.Open();
                    SqlCommand komut = new SqlCommand("SELECT * FROM tbl_koltuk_secim WHERE film_adi = '" + film + "' AND koltuk_adi = '" + dolukoltuklar.Name + "'", conn);
                    SqlDataReader oku = komut.ExecuteReader();

                    
                    if (oku.HasRows)
                    {
                        dolukoltuklar.BackColor = Color.Red;
                    }

                    conn.Close();
                }
            }
        }

        void koltuklar_Click(object sender, EventArgs e)
        {
            string tiklanan = (sender as Button).Name;
            if ((sender as Button).BackColor == Color.Green)
            {
                conn.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO tbl_koltuk_secim(koltuk_adi,film_adi) VALUES('" + tiklanan + "','" + film + "')", conn);
                komut.ExecuteNonQuery();
                conn.Close();

            }




            (sender as Button).BackColor = Color.Red;
            
        }
    }
}
