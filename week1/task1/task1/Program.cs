using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool isprime(int n)//создал метод для проверки чисел на праймство
        {
            if (n < 2) return false;
            for(int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) { return false; }
            }return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//считивал число через консол
            int[] a = new int[n];//создал массив
            string[] s = new string[n];//создал массив строков
            s = Console.ReadLine().Split();//считываю массив и через сплит мы передаем массив чаров
            int count = 0;//переменная для считание количесво праймов
            for(int i = 0; i < n; i++)
            {
                a[i] =int.Parse(s[i]);//считываем в массив
            }
            for(int i = 0; i < n; i++)
            {
                if (isprime(a[i]))
                {
                    count++;//считаем количесво праймов
                }
            }Console.WriteLine(count);//и выводим
            for(int i = 0; i < n; i++)
            {
                if (isprime(a[i])){
                    Console.Write(a[i] + " ");
                }//и показываем на консоле прайм намберов из массива
            }Console.ReadKey();
        }
    }
}
