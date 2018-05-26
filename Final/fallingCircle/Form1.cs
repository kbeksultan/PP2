using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fallingCircle
{
    public partial class Form1 : Form
    {
        int x, y;
        bool ok = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (ok)
            {
                e.Graphics.FillEllipse(Brushes.Red, x, y, 50,50);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ok = true;
            x = int.Parse(textBox1.Text.ToString());
            y = int.Parse(textBox2.Text.ToString());
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            timer1.Interval = 100;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y += 10;
            Refresh();
        }
    }
}
