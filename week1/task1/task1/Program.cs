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
            string[] s = new string[n];
            int k = 0;
            s = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (isprime(a[i]))
                {
                    k++;
                }
            }
            Console.WriteLine(k);
            for (int i = 0; i < n; i++)
            {
                if (isprime(a[i]))
                {
                    Console.Write(a[i] + " ");
                }

            }
            Console.ReadKey();
        }
        static bool isprime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }

}