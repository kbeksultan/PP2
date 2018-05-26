using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic
{
    public partial class Form1 : Form
    {
        GraphicsPath just = new GraphicsPath();
        GraphicsPath sinus = new GraphicsPath();
        GraphicsPath sinxX = new GraphicsPath();
        GraphicsPath sinxpX = new GraphicsPath();

        int x = -15;
        int X = 100;



        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            X += 10;
            if (x == 16)
            {
                sinxX.Reset();
                sinxpX.Reset();
                sinus.Reset();
                just.Reset();
                x = -15;
                X = 100;
            }
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            just.AddLine(x+X,300 + (x) * -10, x + X, 300 + (x) * -10);
            sinus.AddLine(x + X, 300 + ((float)Math.Sin(x)) * -10, x + X, 300 + ((float)Math.Sin(x)) * -10);
            sinxX.AddLine(x + X, 300 + ((float)Math.Sin(x)) * (x) * -10, x + X, 300 + ((float)Math.Sin(x)) * (x) * -10);
            sinxpX.AddLine(x + X, 300 + ((float)Math.Sin(x) + x) *  -10, x + X, 300 + ((float)Math.Sin(x) + x) * -10);

            e.Graphics.DrawLine(new Pen(Color.Black), 100 + 150, 100,100 + 150,600);
            e.Graphics.DrawLine(new Pen(Color.Black), 80, 300, 100 + 320, 300);

            e.Graphics.DrawPath(new Pen(Color.Red),just);
            e.Graphics.DrawPath(new Pen(Color.Blue),sinus);
            e.Graphics.DrawPath(new Pen(Color.Green),sinxX);
            e.Graphics.DrawPath(new Pen(Color.Yellow),sinxpX);

        }


    }
}
