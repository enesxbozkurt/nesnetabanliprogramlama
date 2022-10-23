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
    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }

        public static int musterid = 0;
        public static string ad = "0";
        public static string soyad = "0";
        public static string telefon = "0";
        public static string adres = "0";
        public static string Kadi = "0";
        public static string Ksifre = "0";

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            musterid= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (musterid==1)
            {
                 ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                 soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                 telefon = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                 adres = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                 Kadi = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                 Ksifre = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Musteriler mstr = new Musteriler();
                mstr.ShowDialog();
            }
            else if (musterid==2)
            {
                 ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                 soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                 telefon = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                 adres = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                 Kadi = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                 Ksifre = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Musteriler mstr = new Musteriler();
                mstr.ShowDialog();
            }
            else if (musterid == 3)
            {
                ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                telefon = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                adres = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Kadi = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Ksifre = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Musteriler mstr = new Musteriler();
                mstr.ShowDialog();
            }
        }

        private void Guncelle_Load(object sender, EventArgs e)
        {
            DataTable dtable = new DataTable();
            Form1.conn.Close();
            Form1.conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select MusteriID as 'Müşteri İd',Adi as 'Müşteri Adı',Soyadi as 'Müşteri Soyadı',Telefon as 'Telefon Numarası',Adres,KullaniciAdi,Sifre from tbl_Musteri", Form1.conn);
            adp.Fill(dtable);
            dataGridView1.DataSource = dtable;
            Form1.conn.Close();

            DataTable tablo = new DataTable();
            Form1.conn.Close();
            Form1.conn.Open();
            SqlDataAdapter adp2 = new SqlDataAdapter("select * from tbl_Oyuncu", Form1.conn);
            adp2.Fill(tablo);
            dataGridView2.DataSource = tablo;
            Form1.conn.Close();

        }

        public static bool kontrol=false;
        public static int oyuncuid = 0;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             oyuncuid= Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            if (oyuncuid==1)
            {
                kontrol = true;
                Akgun akgn = new Akgun();
                akgn.ShowDialog();
            }
            else if (oyuncuid==2)
            {
                kontrol = true;
                Polat plt = new Polat();
                plt.ShowDialog();
            }
            else if (oyuncuid==3)
            {
                kontrol = true;
                Hafsanur hfsn = new Hafsanur();
                hfsn.ShowDialog();
            }
            else if (oyuncuid==4)
            {
                kontrol = true;
                Ozgu ozg = new Ozgu();
                ozg.ShowDialog();
            }
            else if (oyuncuid==5)
            {
                kontrol = true;
                Oktay okty = new Oktay();
                okty.ShowDialog();
            }
            else if (oyuncuid == 6)
            {
                kontrol = true;
                Halil hl = new Halil();
                hl.ShowDialog();
            }
            else if (oyuncuid == 7)
            {
                kontrol = true;
                AliAtay ali = new AliAtay();
                ali.ShowDialog();
            }
            else if (oyuncuid == 8)
            {
                kontrol = true;
                Fundaeryigit funda = new Fundaeryigit();
                funda.ShowDialog();
            }
            else if (oyuncuid == 9)
            {
                kontrol = true;
                ErhanUfak erhan = new ErhanUfak();
                erhan.ShowDialog();
            }
            else if (oyuncuid == 10)
            {
                kontrol = true;
                GürkanUygun gürkan = new GürkanUygun();
                gürkan.ShowDialog();
            }
            else if (oyuncuid == 11)
            {
                kontrol = true;
                Kenanimirzalioglu kenan = new Kenanimirzalioglu();
                kenan.ShowDialog();
            }
            else if (oyuncuid == 12)
            {
                kontrol = true;
                Cansudere cansu = new Cansudere();
                cansu.ShowDialog();
            }
            else if (oyuncuid == 13)
            {
                kontrol = true;
               BarışFalay barış = new BarışFalay();
                barış.ShowDialog();
            }
            else if (oyuncuid == 14)
            {
                kontrol = true;
                TuncelKurtiz kurtiz = new TuncelKurtiz();
                kurtiz.ShowDialog();
            }
            else if (oyuncuid == 15)
            {
                kontrol = true;
                Burcinterzioglu burcin=new Burcinterzioglu();
                burcin.ShowDialog();
            }
            else if (oyuncuid == 16)
            {
                kontrol = true;
                Arifpiskin arif = new Arifpiskin();
                arif.ShowDialog();
            }
            else if (oyuncuid == 17)
            {
                kontrol = true;
                Yunusnarin yunus = new Yunusnarin();
                yunus.ShowDialog();
            }
            else if (oyuncuid == 18)
            {
                kontrol = true;
                 Nihatnikerel nihat = new Nihatnikerel();
            nihat.ShowDialog();
            }
            else if (oyuncuid == 19)
            {
                kontrol = true;
                İstemibetil istemi = new İstemibetil();
                istemi.ShowDialog();
            }
            else if (oyuncuid == 20)
            {
                kontrol = true;
                Yigitozsener yigit = new Yigitozsener();
            yigit.ShowDialog();
            }
            else if (oyuncuid == 21)
            {
                kontrol = true;
                Sarpakkaya sarp = new Sarpakkaya();
                sarp.ShowDialog();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
