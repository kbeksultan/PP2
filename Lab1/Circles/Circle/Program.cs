using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        public double rad;
        public double ar;
        public double dtr;
        public double cr;

        public Circle(double rad)
        {
            this.rad = rad;
        }

        public void findArea()
        {
            ar = rad*rad * Math.PI;
        }

        public void Diametr()
        {
            dtr = 2 * rad;
        }

        public void Circumference()
        {
            cr = 2 * Math.PI * rad;
        }

        public override string ToString()
        {
            return this.ar + " " + this.dtr + " " + this.cr;
        }
    }

    class Program
    {
       
        static void Main(string[] args)
        {
            double rad = int.Parse(Console.ReadLine());
            Circle c = new Circle(rad);

            c.findArea();
            c.Diametr();
            c.Circumference();

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
