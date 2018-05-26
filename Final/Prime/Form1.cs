using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool prime(int x)
        {
         
            if (x == 1) return false; 
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            int a = int.Parse(textBox1.Text);
            for (int i = 0; i <= a; i++)
            {
                if (prime(i))
                {
                    label1.Text += i + " "; 
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
