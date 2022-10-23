using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ajansproje
{
    public partial class KvOyuncu : Form
    {
        public KvOyuncu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Polat plt = new Polat();
            plt.ShowDialog();
        }

        private void KvOyuncu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ozgu ozg = new Ozgu();
            ozg.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Oktay okty = new Oktay();
            okty.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ErhanUfak erhan = new ErhanUfak();
            erhan.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            GürkanUygun gurkan = new GürkanUygun();
            gurkan.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            İstemibetil istemi = new İstemibetil();
            istemi.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Nihatnikerel nihat = new Nihatnikerel();
            nihat.ShowDialog();
        }
    }
}
