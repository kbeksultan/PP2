using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FirstSolution4
{
    class Body
    {
        int i;
        public void Draw(object sender, ElapsedEventArgs e)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(52, 5);
            Console.Write(12);
            Console.SetCursorPosition(56, 6);
            Console.Write(1);
            Console.SetCursorPosition(60, 7);
            Console.Write(2);
            Console.SetCursorPosition(64, 8);
            Console.Write(3);
            Console.SetCursorPosition(60, 9);
            Console.Write(4);
            Console.SetCursorPosition(56, 10);
            Console.Write(5);
            Console.SetCursorPosition(52, 11);
            Console.Write(6);
            Console.SetCursorPosition(48, 10);
            Console.Write(7);
            Console.SetCursorPosition(44, 9);
            Console.Write(8);
            Console.SetCursorPosition(40, 8);
            Console.Write(9);
            Console.SetCursorPosition(44, 7);
            Console.Write(10);
            Console.SetCursorPosition(48, 6);
            Console.Write(11);
        }

        public void ChangeColor(object sender, ElapsedEventArgs e)
        {
            i = (i + 1) % 12;
            Console.ForegroundColor = ConsoleColor.Red;
            switch (i)
            {
                case 0:
                    Console.SetCursorPosition(52, 5);
                    Console.Write(12);
                    break;
                case 1:
                    Console.SetCursorPosition(56, 6);
                    Console.Write(1);
                    break;
                case 2:
                    Console.SetCursorPosition(60, 7);
                    Console.Write(2);
                    break;
                case 3:
                    Console.SetCursorPosition(64, 8);
                    Console.Write(3);
                    break;
                case 4:
                    Console.SetCursorPosition(60, 9);
                    Console.Write(4);
                    break;
                case 5:
                    Console.SetCursorPosition(56, 10);
                    Console.Write(5);
                    break;
                case 6:
                    Console.SetCursorPosition(52, 11);
                    Console.Write(6);
                    break;
                case 7:
                    Console.SetCursorPosition(48, 10);
                    Console.Write(7);
                    break;
                case 8:
                    Console.SetCursorPosition(44, 9);
                    Console.Write(8);
                    break;
                case 9:
                    Console.SetCursorPosition(40, 8);
                    Console.Write(9);
                    break;
                case 10:
                    Console.SetCursorPosition(44, 7);
                    Console.Write(10);
                    break;
                case 11:
                    Console.SetCursorPosition(48, 6);
                    Console.Write(11);
                    break;
                default:
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Body b = new Body();
            Timer t = new Timer();
            t.Interval = 1000;
            t.Elapsed += b.Draw;
            t.Elapsed += b.ChangeColor;
            t.Start();
            while (true) { }

        }
    }
}
