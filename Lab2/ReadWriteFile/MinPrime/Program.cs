using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MinPrime
{
    class Program
    {
        static bool prime(string str)
        {
            int x = int.Parse(str);
            if (x == 1) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;

            }
            return true;
        }
        static void Main(string[] args)
        {
            string str = File.ReadAllText(@"D:\Новая папка\Beks.txt");
            string[] s = str.Split(' ');

            string mini = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (prime(s[i]))
                {
                    if (int.Parse(s[i]) < int.Parse(mini))
                    {
                        mini = s[i];
                    }
                }
            }
            
            File.WriteAllText(@"D:\Новая папка\Beks1.txt", mini);
            
        }
    }
}
