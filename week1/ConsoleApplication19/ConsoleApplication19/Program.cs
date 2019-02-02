using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] a = new string[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (n % 2 == 1)
                    {
                        if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                        {
                            a[i, j] = "1";
                        }
                        else if (i == j && i == (n - 1) / 2 && j == (n - 1) / 2)
                        {
                            a[i, j] = "1";
                        }
                        else
                        {
                            a[i, j] = "0";
                        }
                    }
                    else
                    {
                        if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                        {
                            a[i, j] = "1";
                        }
                        else if ((i == j && i == (n - 1) / 2 && j == (n - 1) / 2)||(i==j && i==(n-1)/2+1 && j==(n-1)/2+1)||(i+1==j && i == (n - 1) / 2 + 1 && j == (n - 1) / 2 + 1))
                        {
                            a[i, j] = "1";
                        }
                        else
                        {
                            a[i, j] = "0";
                        }
                    }
                }

            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }Console.WriteLine();
            }

            Console.ReadKey();
            }
        }
    }

