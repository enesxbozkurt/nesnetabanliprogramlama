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
    public partial class Oyuncular : Form
    {
        public Oyuncular()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Akgun akgn = new Akgun();
            akgn.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hafsanur hfsn = new Hafsanur();
            hfsn.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Polat plt = new Polat();
            plt.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ozgu ozg = new Ozgu();
            ozg.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Oktay okty = new Oktay();
            okty.ShowDialog();
        }

        private void Oyuncular_Load(object sender, EventArgs e)
        {
            DataTable dtable = new DataTable();
            Form1.conn.Close();
            Form1.conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select MusteriID as 'Müşteri İd',Adi as 'Müşteri Adı',Soyadi as 'Müşteri Soyadı',Telefon as 'Telefon Numarası',Adres,KullaniciAdi,Sifre from tbl_Musteri", Form1.conn);
            adp.Fill(dtable);
            Form1.conn.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Halil halil = new Halil();
            halil.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AliAtay ali = new AliAtay();
            ali.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Fundaeryigit funda = new Fundaeryigit();
            funda.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ErhanUfak erhan = new ErhanUfak();
            erhan.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            GürkanUygun gurkan = new GürkanUygun();
            gurkan.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            BarışFalay barış = new BarışFalay();
            barış.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Cansudere cansu = new Cansudere();
            cansu.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Kenanimirzalioglu kenanimir = new Kenanimirzalioglu();
            kenanimir.ShowDialog();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Burcinterzioglu burcin = new Burcinterzioglu();
            burcin.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            TuncelKurtiz tuncelKurtiz = new TuncelKurtiz();
            tuncelKurtiz.ShowDialog();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Arifpiskin arif = new Arifpiskin();
            arif.ShowDialog();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Yunusnarin yunus = new Yunusnarin();
            yunus.ShowDialog();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Nihatnikerel nihat = new Nihatnikerel();
            nihat.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            İstemibetil istemi = new İstemibetil();
            istemi.ShowDialog();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Yigitozsener yigit = new Yigitozsener();
            yigit.ShowDialog();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Sarpakkaya sarp = new Sarpakkaya();
            sarp.ShowDialog();
        }
    }
}
