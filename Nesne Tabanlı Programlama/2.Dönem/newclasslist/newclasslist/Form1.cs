using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newclasslist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kulupler kulup = new kulupler();
            kulup.KulupAd = "Muradiye";
            kulup.KulupRenk = "Kırmızı-Siyah";
            kulup.KulupMerkez = "Beşiktaş";

            List<kulupler> KulupList = new List<kulupler>();
            KulupList.Add(kulup);

                listBox1.Items.Add(KulupList[0].KulupAd);
                listBox1.Items.Add(KulupList[0].KulupRenk);
                listBox1.Items.Add(KulupList[0].KulupMerkez);
        }
    }
}
