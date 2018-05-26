using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{

    class Complex
    {
        int x, y;

        public Complex(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Complex operator +(Complex c1,Complex c2)
        {
            return new Complex(c1.x + c2.x, c1.y + c2.y);
        }

        public override string ToString()       
        {
            return x + " " + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(3,5);
            Complex c2 = new Complex(1,2);
            Console.WriteLine(c1 + c2);
        }
    }
}
