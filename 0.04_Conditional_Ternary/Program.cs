using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ternary Operator
            

            int num = 10;
           // if (num == 7)
            //    Console.WriteLine("Hey this is the number 7");
            //else
            //    Console.WriteLine("This number isn't 7.");
            //Console.ReadLine();

            Console.WriteLine(num == 7 ? "Hey this is the number 7" : "This number isn't 7.");
            Console.ReadLine();

            Console.WriteLine(" Enter your energy level 1-5");
            int energy = Console.ReadLine();

        }
    }
}
