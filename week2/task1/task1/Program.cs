using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Ержан\Desktop\pp2\week2\task1\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
            bool ok = true;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    ok =false;
                    break;
                }
            }
            if (ok)
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
            fs.Close();
            sr.Close();
            Console.ReadKey();

        }
    }
}
