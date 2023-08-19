using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //abstract and virutal
    public class Virtual
    {
        public virtual void Method()
        {
            Console.WriteLine("Welcome");
        }
      class Sailu : Virtual
        {
            public override void Method()
            {
                Console.WriteLine("Our World");
            }
        }
       
        public static void Main()
        {
            Virtual v = new Virtual();
            Virtual s = new Sailu();
            v.Method();
            s.Method();
        }
    }

    
}
