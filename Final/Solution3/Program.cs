using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution3
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"D: \Users\Бексултан\Desktop\KBTU";
            DirectoryInfo di = new DirectoryInfo(path);
            
            foreach (FileInfo f in di.GetFiles())
            {
                FileStream fs = new FileStream(f.FullName, FileMode.Open, FileAccess.ReadWrite);
                StreamReader sr = new StreamReader(fs);

                string s = sr.ReadToEnd();

                if (s.Contains("fit"))
                {
                    Console.WriteLine(f.Name);
                }
            }

            Console.ReadKey();
        }
    }
}
