using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSolution2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Берик\Source\Repos\Final\Second1\input.txt";
            FileStream fs = new FileStream(path,FileMode.Open,FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            List<int> list = new List<int>();
            string s = sr.ReadToEnd();
            string[] ss = s.Split(' ');

            for(int i = 0; i < ss.Length; i++)
            {
                list.Add(int.Parse(ss[i]));
            }
            list.Sort();
            
            Console.WriteLine(list[list.Count - 2]);
        }
    }
}
