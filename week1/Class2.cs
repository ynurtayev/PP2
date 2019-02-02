using System;

namespace Ex3
{
    class Program
    {
        static void Main(string [] args)
        {
            string s = Console.Readline();
            string[] arr = s.Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);
            Console.WriteLine(a + b + c);
        }
    }
}