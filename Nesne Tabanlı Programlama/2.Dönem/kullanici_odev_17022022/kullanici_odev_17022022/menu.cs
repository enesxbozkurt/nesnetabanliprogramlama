using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanici_odev_17022022
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.id.ToString();
            textBox2.Text = Form1.ad;
            textBox3.Text = Form1.soyad;
            textBox4.Text = Form1.telefon_no;
            textBox5.Text = Form1.araba_markasi;
            textBox6.Text = Form1.ilce;
            textBox7.Text = Form1.kadi;
            textBox8.Text = Form1.ksifre;
        }
    }
}
