using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace calc
{

    public partial class Form1 : Form
    {
        Brain brain = new Brain();
        public Form1()
        {
            InitializeComponent();
            brain.invoker = ShowInfo;
        }
        public void ShowInfo(string msg)
        {
            text.Text = msg;
        }
        public void BtnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            brain.Process(btn.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }
    }
}
