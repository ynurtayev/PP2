using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] s = new string[n];
            s = Console.ReadLine().Split();
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
