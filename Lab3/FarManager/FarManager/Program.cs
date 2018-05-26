using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarManager
{
    class Program
    {
        static void PrintState(DirectoryInfo directory, int index)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            FileSystemInfo[] fs = directory.GetFileSystemInfos();

            for (int i = 0; i < fs.Length; i++)
            {
                FileSystemInfo fileSystemInfo = fs[i];
                if (i == index)
                    Console.BackgroundColor = ConsoleColor.Gray;
                else
                    Console.BackgroundColor = ConsoleColor.DarkBlue;

                if (fileSystemInfo.GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                Console.WriteLine(fileSystemInfo.Name);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            int index = 0;
            int n = dir.GetFileSystemInfos().Length;
            PrintState(dir, index);
            bool quit = true;
            while (quit)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    index++;
                    if (index == n)
                        index = 0;
                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    index--;
                    if (index < 0)
                        index = n - 1;
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    try
                    {
                        if (dir.GetFileSystemInfos()[index].GetType() == typeof(DirectoryInfo))
                        {
                            dir = new DirectoryInfo(dir.GetFileSystemInfos()[index].FullName);
                            index = 0;
                            n = dir.GetFileSystemInfos().Length;
                        }
                        else
                        {
                            StreamReader sr = new StreamReader(dir.GetFileSystemInfos()[index].FullName);
                            string s = sr.ReadToEnd();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(s);
                            Console.ReadKey();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("cannot open file");
                    }
                }
                if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (dir.Parent != null)//
                    {
                        dir = dir.Parent;
                        index = 0;
                        n = dir.GetFileSystemInfos().Length;// 
                    }
                    else
                        break;
                }

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    quit = false;
                }
                PrintState(dir, index);
            }
        }
    }
}