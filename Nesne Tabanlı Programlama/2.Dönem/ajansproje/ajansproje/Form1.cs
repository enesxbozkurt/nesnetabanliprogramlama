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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=db_ajans;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriGiris musterigrs = new MusteriGiris();
            musterigrs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticigrs = new YoneticiGiris();
            yoneticigrs.ShowDialog();
        }
    }
}
