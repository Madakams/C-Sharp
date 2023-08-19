using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Democlass
    {
        public  void Method()
        {
            Console.WriteLine("Hello world");
           // name = "vamsi";
        }
    }
    class Master : Accessmodifier
    {
        public void Method1()
        {
            Console.WriteLine(name);
        }
    }
}
