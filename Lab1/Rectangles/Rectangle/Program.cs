using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{   
    class Rectangles
    {
        public int width;
        public int height;
        public int area;
        public int perimetr;

        public Rectangles(int a,int b)
        {
            width = a;
            height = b;
        }

        public void findArea()
        {
            area = width * height;
        }
        public void findPerimetr()
        {
            perimetr =  2 * (width + height);
        }

        public override string ToString()
        {
            return this.area + " " + this.perimetr;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Rectangles r = new Rectangles(a,b);
            r.findArea();
            r.findPerimetr();

            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
