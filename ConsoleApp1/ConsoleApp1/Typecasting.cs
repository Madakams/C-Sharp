using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Typecasting
    {
        //implicit
        public static void Main()
        {
            //int age = 20;
            //double d = age;
            //Console.WriteLine(d);

            //explicit
            double d = 13.34;
            int i = (int)d;
            Console.WriteLine(i);
            Console.WriteLine(d);
        }
    }
}
