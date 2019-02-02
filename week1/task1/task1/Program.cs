using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool isprime(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) { return false; }
            }return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] s = new string[n];
            s = Console.ReadLine().Split();
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                a[i] =int.Parse(s[i]);
            }
            for(int i = 0; i < n; i++)
            {
                if (isprime(a[i]))
                {
                    count++;
                }
            }Console.WriteLine(count);
            for(int i = 0; i < n; i++)
            {
                if (isprime(a[i])){
                    Console.Write(a[i] + " ");
                }
            }Console.ReadKey();
        }
    }
}
