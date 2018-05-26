using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Calc calc = new Calc();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void resultBtnClck(object sender, EventArgs e)
        {
            calc.currentState = CalcStates.FirstNumber;
            calc.secondNumber = double.Parse(textBox1.Text);

            switch (calc.currentOperation)
            {
                case OperationsState.Plus:
                    calc.resultNumber = calc.firstNumber + calc.secondNumber;
                    break;
                case OperationsState.Minus:
                    calc.resultNumber = calc.firstNumber - calc.secondNumber;
                    break;
                case OperationsState.Multiply:
                    calc.resultNumber = calc.firstNumber * calc.secondNumber;
                    break;
                case OperationsState.Divide:
                    calc.resultNumber = calc.firstNumber / calc.secondNumber;
                    break;
                default:
                    break;
            }

            if (calc.resultNumber.ToString() == "∞")
            {
                textBox1.Text = "Error";
            }
            else
            {
                textBox1.Text = calc.resultNumber.ToString();
            }
        }

        private void dgtBtnClck(object sender, EventArgs e)
        {
            Button dgtBtn = sender as Button;
            if (textBox1.Text == "0")
            {
                textBox1.Text = dgtBtn.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + dgtBtn.Text;
            }
        }


        private void operationBtnClck(object sender, EventArgs e)
        {
            Button operationBtn = sender as Button;

            if (operationBtn.Text == "+")
            {
                calc.currentOperation = OperationsState.Plus;
            }
            else if (operationBtn.Text == "-")
            {
                calc.currentOperation = OperationsState.Minus;
            }else if (operationBtn.Text == "×")
            {
                calc.currentOperation = OperationsState.Multiply;
            }else if(operationBtn.Text == "÷")
            {
                calc.currentOperation = OperationsState.Divide;
            }

            calc.currentState = CalcStates.SecondNumber;

            if (calc.resultNumber != 0)
            {
                calc.firstNumber = calc.resultNumber;
            }
            else
            {
                calc.firstNumber = double.Parse(textBox1.Text);
            }

            textBox1.Text = "0";
        }

        private void operationSqrt(object sender, EventArgs e)
        {
            double opersqrt = Math.Sqrt(double.Parse(textBox1.Text));

            textBox1.Text = opersqrt.ToString();
        }

        private void operationPows(object sender, EventArgs e)
        {
            double pows = Math.Pow(double.Parse(textBox1.Text), 2);

            textBox1.Text = pows.ToString();
        }

        private void operation1(object sender, EventArgs e)
        {
            double x = 1 / (double.Parse(textBox1.Text));

            if ((textBox1.Text = x.ToString()) == "∞")
            {
                textBox1.Text = "Error";
            }
            else
            {
                textBox1.Text = x.ToString();
            }
        }
        
        private void operationPercent(object sender, EventArgs e)
        {
            double percent = double.Parse(textBox1.Text)/100;
            textBox1.Text = percent.ToString(); 
        }

        private void operationdot(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
           
        }

        private void Delete(object sender, EventArgs e) 
        {
            string s = textBox1.Text;
            string ss = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                ss += s[i];
            }
            textBox1.Text = ss;
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "0";
            }
        }

        private void CE(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Clear(object sender, EventArgs e)
        {
            calc.currentState = CalcStates.FirstNumber;
            calc.firstNumber = 0;
            textBox1.Text = "0";
        }

        private void save_click(object sender, EventArgs e)
        {
            calc.memory.Add(textBox1.Text);
            //changecolorwhenfalse();
            calc.flag = true;
        }

        private void read_click(object sender, EventArgs e)
        {
            if (calc.flag == true)
            {

                textBox1.Text = calc.memory[calc.memory.Count - 1];

            }
        }

        private void clear_click(object sender, EventArgs e)
        {
            //Memory Clear
            for (int i = 0; i < calc.memory.Count; i++)
            {
                calc.memory[i] = "";
            }
            //changecolorwhentrue();
            calc.flag = false;
        }

        private void subtract_click(object sender, EventArgs e)
        {
            // Memory subtract
            if (calc.flag == true)
            {
                string b = (double.Parse(calc.memory[calc.memory.Count - 1]) - double.Parse(textBox1.Text)).ToString();
                calc.memory.Add(b);
            }
        }

        private void add_click(object sender, EventArgs e)
        {
            // Memory add 

            if (calc.flag == true)
            {
                string b = (double.Parse(textBox1.Text) + double.Parse(calc.memory[calc.memory.Count - 1])).ToString();
                calc.memory.Add(b);
            }
        }

        private void PlusMinus(object sender, EventArgs e)
        {
            double pm = double.Parse(textBox1.Text) * (-1);
            textBox1.Text = pm.ToString();
        }

        private void display_CursorChanged(object sender, EventArgs e)
        {

        }

        /*public void changecolorwhentrue()
        {
            button13.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button21.BackColor = Color.Red;
        }
        public void changecolorwhenfalse()
        {
            button13.BackColor = Color.Silver;
            button4.BackColor = Color.Silver;
            button2.BackColor = Color.Silver;
            button21.BackColor = Color.Silver;
        }*/
    }
}
