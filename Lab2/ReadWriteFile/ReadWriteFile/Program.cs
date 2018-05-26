using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Открывает текстовый файл, считывает все строки файла в строку и затем закрывает файл.
            string str = File.ReadAllText(@"D:\Новая папка\Beks.txt");
            string[] s = str.Split(' ');

            string maxi = s[0];
            string mini = s[0];

            for (int i = 0; i < s.Length; i++)
            {
                if(int.Parse(s[i]) > int.Parse(maxi))
                {
                    maxi = s[i];
                }else if (int.Parse(s[i]) < int.Parse(mini))
                {
                    mini = s[i];
                }
            }
            //Создает новый файл, записывает в него содержимое и затем закрывает файл.
            //Если целевой файл уже существует, он будет перезаписан.
            Console.WriteLine(maxi + " " + mini);
        }
    }
}
