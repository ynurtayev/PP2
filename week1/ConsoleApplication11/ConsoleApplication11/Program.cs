using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            
            string[] parts = line2.Split(new char[] { ' ', '', '' });
            Console.WriteLine(parts.Length);
            for (int i = 0; i < parts.Length; ++i)
            {
                Console.WriteLine(parts[i]);
            }

        }

        }
    }
}
