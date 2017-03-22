using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_If
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOn = true;
            bool isHot = false;

            /*
             Comparison operators
             == is equal to
             >- Greater than
             <- Less than
             != Not Equal
             */

            //if (isOn) //if whats in between ()parenthases is true then run code.
            //{
            //    Console.WriteLine("The light is on.");
            //}

            //Console.ReadLine();

            //    bool admin = true;
            //    bool user = false;

            //    if (admin)
            //    {
            //        Console.WriteLine("Welcome to the site Admin.");
            //    }
            //    if (!admin)
            //    {
            //        Console.WriteLine("Go home noob!");
            //    }

            //    Console.ReadLine();
            //}

            bool admin = true;
            bool user = false;
            bool isLoggedIn = true;

            if (admin && isLoggedIn)
            {
                Console.WriteLine("Welcome to the site Admin.");
            }
            if (!admin)
            {
                Console.WriteLine("Go home noob!");
            }

            Console.ReadLine();

        }




}
