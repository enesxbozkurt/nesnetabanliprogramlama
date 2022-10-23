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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_restaurant;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteri musteriler = new musteri();
            musteriler.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personel personeller = new personel();
            personeller.ShowDialog();
        }
    }
}
