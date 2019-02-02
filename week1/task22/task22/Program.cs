using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    class Student
    {
        public string name;
        public int id;
        public int year;
        public Student(string aName,int aId,int aYear)
        {
            name = aName;
            id = aId;
            year = ++aYear;
       

        }

        static void Main(string[] args)
        {
            Student student1 = new Student("Yernazar", 18141312, 2018);
            Console.WriteLine(student1.year);
            Console.WriteLine(student1.name);
            Console.WriteLine(student1.id);
            Console.ReadKey();
        }
    }
}
