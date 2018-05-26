using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate(int a,int b);
    
    class Numbers
    {
        int a, b;

        public Numbers(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Sum(int a,int b)
        {
            Console.WriteLine(a + b);
        }

    }

    public class FirstDelegate
    {
        public void Process()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Numbers nmb = new Numbers(a,b);
            MyDelegate md = nmb.Sum;
            Thread.Sleep(10000);
            md.Invoke(a, b);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FirstDelegate d = new FirstDelegate();
            d.Process();
        }
    }
}
