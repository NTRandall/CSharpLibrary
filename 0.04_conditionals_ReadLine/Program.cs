using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_conditionals_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();
             
            if (feelingNumber == "5")
            {
                Console.WriteLine("Wow man, that's super");
            }
            else if (feelingNumber == "4")
            {
                Console.WriteLine("Super duper");
            }
            if (feelingNumber == "3")
            {
                Console.WriteLine("Chin up");
            }
            if (feelingNumber == "2")
            {
                Console.WriteLine("Don't Cry");
            }
            if (feelingNumber == "1")
            {
                Console.WriteLine("Wow man, that's super");
            }
            Console.ReadLine();
        }
    }
}
