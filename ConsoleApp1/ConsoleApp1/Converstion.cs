using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Converstion
    {
        public static void Main()
        {
            Console.WriteLine("Enter user name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter ur age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age<=18)
            {
                Console.WriteLine("You are Eligible");
            }
            else
            {
                Console.WriteLine("Not eligible");
            }
        }
    }
}
