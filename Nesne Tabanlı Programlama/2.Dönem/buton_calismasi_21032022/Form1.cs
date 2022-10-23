using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buton_calismasi_21032022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static string filmadi = "";

        private void _filmsec(object sender, EventArgs e)
        {
            filmadi = (sender as PictureBox).Name;
            koltuksec sec = new koltuksec();
            sec.ShowDialog();
        }
    }
}
