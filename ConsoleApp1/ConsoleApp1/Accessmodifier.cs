using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Accessmodifier
    {
        //private string name = "Vamsi";
        //public string name = "Vamsi";
        //protected string name = "Vamsi";
        //internal string name = "Vamsi";
        protected internal string name = "Vamsi";
    }
    //class Access : Accessmodifier
    //{

    //    public void Method()
    //    {
    //        Console.WriteLine(name);
    //    }
    //internal
    class Super
    {
        public static void Main()
        {
            Accessmodifier a = new Accessmodifier();
            //Access c = new Access();
            Console.WriteLine(a.name);
        }
    }

}