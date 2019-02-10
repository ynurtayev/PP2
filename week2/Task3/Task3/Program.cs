using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void printInfo(FileSystemInfo di ,int k)
        {
            string s = new string('\t', k);
            s += di.Name;
            Console.WriteLine(s);
            if (di.GetType() == typeof(DirectoryInfo))
            {
                var v = (di as DirectoryInfo).GetFileSystemInfos();
                foreach(var i in v)
                {
                    printInfo(i, k + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Ержан\Desktop\pp2");
            printInfo(di, 0);
            Console.ReadKey();
        }
    }
}
