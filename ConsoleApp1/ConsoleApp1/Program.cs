using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //class and object
    class Program
    {
        //method - it doesnt have return 
        public void Method(String name)
        {
            Console.WriteLine("this is a technology");
        }
        
        //it have return type
        public int Method1(int name)
        {
            return name;
        }

     
        class Derived
        {

            //point of execution
            static void Main(string[] args)
            {
                //creating of object
                Program program = new Program();
                //calling method
                program.Method("Vamsi");
            }
        }
    }
}
