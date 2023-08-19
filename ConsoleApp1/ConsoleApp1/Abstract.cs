using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //abstraction abstractclass
    public abstract class Abstract
    {
        //abstract method
        public abstract void Method();
    }
    //mass-sub class to inherit base class-abstract
    class Mass : Abstract
    {
        //override is a key word which is used for override the base class method.
        public override void Method()
        {
            Console.WriteLine("Vamsi");
        }
        public static void Main(String[] args)
        {
            Mass m = new Mass();
            m.Method();
        }
    }
   
}
