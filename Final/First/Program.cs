using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int k = 1;

            for (int i = 1; i <= N; i++)
            {
                k *= i;
            }
            
            Console.WriteLine(k);
        }
    }
}
