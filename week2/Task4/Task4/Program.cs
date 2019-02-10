using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //created txt for check
            string s = @"test.txt";
            //created file
            var c = File.Create(@"C: \Users\Ержан\Desktop\pp2\week2\Task4\create\" + s);
            c.Close();
            //copyed first file and deleted first file
            File.Copy(@"C: \Users\Ержан\Desktop\pp2\week2\Task4\create\" + s, @"C: \Users\Ержан\Desktop\pp2\week2\Task4\copy\" + s);
            File.Delete(@"C: \Users\Ержан\Desktop\pp2\week2\Task4\create\" + s);
        }
    }
}
