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
    public partial class Yoneticiİslem : Form
    {
        public Yoneticiİslem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oyuncular oync = new Oyuncular();
            oync.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ekleİslem ekl = new Ekleİslem();
            ekl.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guncelle gnc = new Guncelle();
            gnc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sil sl = new Sil();
            sl.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GorusmeGoruntule grsm = new GorusmeGoruntule();
            grsm.ShowDialog();
        }

        private void Yoneticiİslem_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DiziEkle dzekl = new DiziEkle();
            dzekl.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Rated rt = new Rated();
            rt.ShowDialog();
        }
    }
}
