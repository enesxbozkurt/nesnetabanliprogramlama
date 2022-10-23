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
    public partial class LsOyuncular : Form
    {
        public LsOyuncular()
        {
            InitializeComponent();
        }


        private void Oyuncular_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Akgun akgn = new Akgun();
            akgn.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hafsanur hfsn = new Hafsanur();
            hfsn.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Halil hl = new Halil();
            hl.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AliAtay ali = new AliAtay();
            ali.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Fundaeryigit funda = new Fundaeryigit();
            funda.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Arifpiskin arif = new Arifpiskin();
            arif.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Yunusnarin yunus = new Yunusnarin();
            yunus.ShowDialog();
        }
    }
}
