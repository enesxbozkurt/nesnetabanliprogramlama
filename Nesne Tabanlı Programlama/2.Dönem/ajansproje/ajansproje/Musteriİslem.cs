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
    public partial class Musteriİslem : Form
    {
        public Musteriİslem()
        {   
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            KvOyuncu kvoync = new KvOyuncu();
                    kvoync.ShowDialog();
        }

        private void Musteriİslem_Load(object sender, EventArgs e)
        {
            Form1.conn.Close();
            Form1.conn.Open();
            SqlCommand listele = new SqlCommand("select * from tbl_Dizi",Form1.conn);
            SqlDataReader oku = listele.ExecuteReader();
            while (oku.Read())
            {
                if (oku["DiziAd"].ToString()=="SonYaz")
                {
                    pictureBox1.ImageLocation = oku["Resim"].ToString();
                }
                else if (oku["DiziAd"].ToString() == "KurtlarVadisi")
                {
                    pictureBox2.ImageLocation = oku["Resim"].ToString();
                }
                else if (oku["DiziAd"].ToString() == "Ezel")
                {
                    pictureBox3.ImageLocation = oku["Resim"].ToString();
                }

            }
            Form1.conn.Close();
            //int x = 50;
            //int y = 350;
            //int xartis = 10;
            //int yartis = 100;
            //Form1.conn.Close();
            //Form1.conn.Open();
            //SqlCommand list = new SqlCommand("Select * from tbl_Dizi", Form1.conn);
            //SqlDataReader okus = listele.ExecuteReader();
            //while (okus.Read())
            //{
            //    PictureBox resim = new PictureBox();
            //    resim.Name = okus["DiziAd"].ToString();
            //    resim.Text = okus["DiziID"].ToString() + " Resmi";
            //    resim.Size = new Size(211, 239);
            //    resim.ImageLocation = okus["Resim"].ToString();
            //    resim.Click += Resim_Click;
            //    resim.Location = new Point(x, y);
            //    x = x + xartis;
            //    y = y + yartis;
            //    groupBox1.Controls.Add(resim);
            //}

            //Form1.conn.Close();
        }

        //private void Resim_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LsOyuncular oync = new LsOyuncular();
            oync.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EzelOyuncular ezl = new EzelOyuncular();
            ezl.ShowDialog();
        }
    }
}
