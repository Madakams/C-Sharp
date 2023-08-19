using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Encapsulation
    {
       // private string firstName;
        public string FirstName
        {
            //must and should we use get -return and set -value input ivadaniki
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
      
        public static void Main()
        {
            Encapsulation e = new Encapsulation();
            e.FirstName = "Pidikiti";
           // e.Method();
           // e.FirstName = "Pidikiti";
            Console.WriteLine(e.FirstName);
        }
    }
}
