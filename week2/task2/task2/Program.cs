﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace task2
{
    class Program
    {
        static bool isPrime(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }return true;
        }
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream(@"C:\Users\Ержан\Desktop\pp2\week2\task2\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs1);
            String s = sr.ReadToEnd();
            string[] ss = s.Split();
            int[] a = new int[ss.Length];
            for(int i = 0; i < a.Length; i++)
            {
                a[i]=int.Parse(ss[i]);
            } 
           
            FileStream fs2 = new FileStream(@"C:\Users\Ержан\Desktop\pp2\week2\task2\output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);
            string f = "";
            for(int i = 0; i < a.Length; i++)
            {
                if (isPrime(a[i]))
                {
                    f += a[i] + " ";
                }
            }
           sw.Write(f);


            Console.ReadKey();

            sw.Close();
            fs2.Close();
            sr.Close();
            fs1.Close();


        }
    }
}