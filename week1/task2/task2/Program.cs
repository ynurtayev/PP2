using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        private string name, id;
        private int year;
        public Student(string name, string id)//here  all variables 
        {
            this.name =name;
            this.id =id;
            year = 2018;
        }
        public string GetName()//constructor that return name
        {
            return name;
        }
        public string GetId()//return id
        {
            return id;
        }
        public int GetYear()//return year
        {
            return year;
        }
        public void Increment()//do +1 every year
        {
            year++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student F = new Student("Yerzhan", "18BD141312");
            Console.WriteLine(F.GetName() + " " + F.GetId());
            F.Increment();
            Console.WriteLine(F.GetYear());
            Console.ReadKey();
        }
    }
}