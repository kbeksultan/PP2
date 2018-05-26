using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        bool clicked;
        Graphics g;
        int width = 0, height = 0, x = 0, y = 0;

        
       
        string[] s = new string[10];

        public Form1()
        {
            InitializeComponent();
            clicked = false;
            g = CreateGraphics();

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            clicked = true;
            s[0] = "Green";
            s[1] = "Black";
            s[2] += "Blue";
            s[3] = "Red";
            s[4] = "Yellow";

            if (clicked)
            {
                while (width < 200 && height < 200)
                {
                    string a = s[new Random().Next(0, 4)];

                    g.DrawEllipse(new Pen(Color.FromName(a)), x, y, width, height);
                    width += 6;
                    height += 6;
                    x += 6;
                    y += 6;
                }
            }
            width = 0;
            height = 0;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }


    }
}
