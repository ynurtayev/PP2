using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] a = new string[n,n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i == j || i > j)
                    {
                        a[i, j] = "[*]";
                    }
                    else
                    {
                        a[i, j] = "";
                    }
                }
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }Console.WriteLine();
            }Console.ReadKey();
        }
    }
}
