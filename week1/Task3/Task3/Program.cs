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
            int n = int.Parse(Console.ReadLine()); // Read number of integers
            string[] a = Console.ReadLine().Split(' '); // Read string and seperate it into n strings using split
            int[] Answer = new int[2 * n]; // Create array with size 2*n
            for (int i = 0; i < n; ++i)
            {
                Answer[i * 2] = Answer[2 * i + 1] = int.Parse(a[i]); // Convert string into integer and add it twice to our array
            }
            for (int i = 0; i < 2 * n; ++i)
            {
                Console.Write(Answer[i] + " "); // Print the array
            }
        }
    }
}