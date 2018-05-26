using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingCar
{
    public partial class Form1 : Form
    {
        int x, y;

        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Red),x,y,100,30);

            e.Graphics.DrawEllipse(new Pen(Color.Red), x + 20, y + 30, 10, 10);
            e.Graphics.DrawEllipse(new Pen(Color.Red), x + 100 - 20, y + 30, 10, 10);
            //Width;
            //Height
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.Up:
                    y--;
                    break;
                case Keys.Right:
                    break;
                    x++;
                case Keys.Down:
                    break;
                    y++;
                case Keys.Left:
                    x--;
                    break;
            }
            Refresh();
        }
        
    }
}
