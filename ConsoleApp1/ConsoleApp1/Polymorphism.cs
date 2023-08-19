//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public class Polymorphism
//    {
//        public void Method()
//        {
//            Console.WriteLine("Sailu");
//        }

//    }
//    class Jerry : Polymorphism
//    {
//        public void Method()
//        {
//            Console.WriteLine("I L U");
//        }
//    }
//    class Vamsi : Polymorphism
//    {
//        public void Method()
//        {
//            Console.WriteLine("Wecolme to our world");
//        }
//    }
//    class Project
//    {
//        public static void Main(String[] args)
//        {
//            Polymorphism p = new Polymorphism();
//            Polymorphism p1 = new Jerry();
//            Polymorphism p2 = new Vamsi();
//            p.Method();
//            p1.Method();
//            p2.Method();
//        }
//    }

//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Polymorphism
    {
        public void Method()
        {
            Console.WriteLine("Sailu");

        }
        class Jerry : Polymorphism
        {
            public void Method1()
            {
                Console.WriteLine("I L U");
            }
        }
        class Vamsi : Polymorphism

        {
            public void Method2()
            {
                Console.WriteLine("Wecolme to our world");
            }
        }
        class Project
        {
            public static void Main(String[] args)
            {
                Polymorphism p = new Polymorphism();
                Jerry p1 = new Jerry();
                Vamsi p2 = new Vamsi();
                p.Method();
                p1.Method1();
                p2.Method2();
            }
        }
    }
}
