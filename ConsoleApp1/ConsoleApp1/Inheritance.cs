using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Inheritance
    {
        //public variable creation
        public string animal = "Vamsi";

        public void Sound()
        {
            Console.WriteLine("inkainka");
        }
        class Tom : Inheritance
        {
            public void Sound1()
            {
                Console.WriteLine("cheppu");
            }
            public static void Main()
            {
                Tom t = new Tom();
                t.Sound();
                t.Sound1();
                Console.WriteLine(t.animal);
            }
        }
    }
}
