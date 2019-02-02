using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//считоваю н
            int[] a = new int[n];//создал массив
            int k = 0;//создал переменную для считование количество праймов
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());//заполнял массив
            }
            for(int i = 0; i < n; i++)
            {
                if (isprime(a[i]))//проверяю на праймство и считваю количество праймов в массиве
                {
                    k++;
                }
            }
            Console.WriteLine(k);//количество праймов
            for(int i = 0; i < n; i++)
            {
                if (isprime(a[i]))
                {
                    Console.Write(a[i] + " ");// проверял на праймство каждый элемент массива и показываю праймов  
                }
                
            }
            Console.ReadKey();//для того чтобы терминал не закрывался сразу 
        }
        static bool isprime(int x)//функция или метод для проверки на праймство
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