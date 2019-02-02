using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int k = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write(i+" ");
                k++;

            }Console.WriteLine(k);
            Console.ReadKey();
        }
        static bool isprime(int x)
        {
            if (x < 2) return false;
            for(int i = 2; i * i <= x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}
