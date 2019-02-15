using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student//created class student
    {
        string name;//declaring variables
        public int year;
        string id;
    public Student(string name, string id)//constructor
    {
            this.name = name;
            this.id = id;
    }
    public String getName()//constructor that return name
    {
        return name;
    }
    public String getId()//constructor that return id
    {
        return id;
    }
    public int ayear(int year)//return impecment year
    {
        return year;
        ++year;
    }


}
class Program
    {
        static void Main(string[] args)
        {

        }
    }
}