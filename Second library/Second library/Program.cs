using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using first;



namespace Second_library
{
    class Program
    {
        static void Main(string[] args)

        {
            printer myprinterfirst = new printer();
            myprinterfirst.Write("so happy it works");
           // program2.read2("sandy thank Godoooo");
        }
    }
    class program2
    {


       public static void read2(string my)
        {

            Console.WriteLine("--------------{0}--------------",my);
            Console.ReadLine();

        }
    }

}

