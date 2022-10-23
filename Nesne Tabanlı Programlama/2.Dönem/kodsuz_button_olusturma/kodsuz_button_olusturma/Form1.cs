using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kodsuz_button_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int bitis = Convert.ToInt32(textBox1.Text);
            int x = 30;
            int y = 50;
            for (int i = 1; i <= bitis; i++)
            {
                Button btn = new Button();
                btn.Name = "Button" + i.ToString();
                btn.Text = "Kamera" + i.ToString();
                btn.Location = new Point(x, y);
                btn.Size = new Size(100, 50);
                btn.Click += new EventHandler(button1_Click);
                btn.ForeColor = Color.White;
                btn.BackColor = Color.Green;
                btn.FlatStyle = FlatStyle.Flat;
                this.Controls.Add(btn);
                x = x + 150;
                if (i % 5 == 0)
                {
                    x = 30;
                    y = y + 100;
                }
            }
        }
    }
}
