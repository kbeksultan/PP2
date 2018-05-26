using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clock2
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            Console.CursorVisible = false;
            string[] times = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            while (true)
            {
                Console.Clear();
                if (index == 12)
                {
                    index = 0;
                }
                for (int i = 0; i < times.Length; i++)
                {
                    if (index == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.SetCursorPosition(i, i + 5);
                    Console.WriteLine(times[i]);


                }
                index++;
                Thread.Sleep(1000);
            }
        }
    }
}