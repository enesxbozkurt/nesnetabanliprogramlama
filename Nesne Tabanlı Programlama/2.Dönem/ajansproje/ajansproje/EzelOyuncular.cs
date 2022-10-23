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
    public partial class EzelOyuncular : Form
    {
        public EzelOyuncular()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Kenanimirzalioglu kenan = new Kenanimirzalioglu();
            kenan.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cansudere cansu = new Cansudere();
            cansu.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BarışFalay barış = new BarışFalay();
            barış.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Burcinterzioglu burcin = new Burcinterzioglu();
            burcin.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TuncelKurtiz tuncel = new TuncelKurtiz();
            tuncel.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Yigitozsener yigit = new Yigitozsener();
            yigit.ShowDialog();
        }

        private void EzelOyuncular_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Sarpakkaya sarp = new Sarpakkaya();
            sarp.ShowDialog();

        }
    }
}
