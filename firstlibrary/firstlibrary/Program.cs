using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using first;
using firstlibrary;

 namespace firstlibrary
{
     public class Program
    {
        static void Main(string[] args)
        {
            printer myprinter = new printer();
            
           // printer.Write("hello");
            myprinter.Write("you");
        }
    }

  /** class printer {

       public void Write(string mystring)
        {
            Console.WriteLine("===== {0} =====",mystring);
            Console.ReadLine();

        }
           
           
        }**/
}
namespace first
{
    

   public class printer
    {

        public void Write(string mystring)
        {
            Console.WriteLine("===== {0} =====", mystring);
            Console.ReadLine();

        }


    }
}
    


    

