using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        bool prime(int a)
        {
            if (a < 2){
                return false;
            }
            for(int i = 2; i * i <= a; i++)
            {
                if (a % i == 0) return false;
            }return true;
        }
        static void Main(string[] args)
        {
           
        }
    }
}
