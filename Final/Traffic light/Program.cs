using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Traffic_light
{
    class Program
    {
        public static void Traffic()
        {
            string path = @"C:\Users\Берик\Source\Repos\Final\Traffic light\input.txt";
          
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadToEnd();

            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(s);
                        Console.WriteLine(' ');
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(s);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(' ');
                        
                        Console.WriteLine(s);
                       
                        Thread.Sleep(1000);
                    }

                    if (i == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(s);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(' ');
                        Console.WriteLine(s);
                        Console.WriteLine(' ');
                        Console.ForegroundColor = ConsoleColor.White;                     
                        Console.WriteLine(s);
                        

                        Thread.Sleep(1000);

                    }

                    if (i == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(s);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(' ');
                        Console.WriteLine(s);
                        Console.WriteLine(' ');
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(s);
                    

                        Thread.Sleep(1000);
                    }

                    Console.Clear();
                }
            }
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Thread tr = new Thread(Traffic);
            tr.Start();
        }
    }
}
