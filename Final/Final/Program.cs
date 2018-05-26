using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            // Console.WriteLine(Math.Pow(2, N));

            int count = 1;

            for(int i = 0;i < N; i++)
            {
                count *= 2;
            }

            Console.WriteLine(count);
        }
    }
}
