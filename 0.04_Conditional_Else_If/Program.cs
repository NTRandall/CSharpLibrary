using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_Else_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int bankAccount = 50000;
            int debt = 13500;
            int difference = bankAccount - debt;

            int taxSeason = 50000;

            difference =- taxSeason;

            Console.WriteLine
                ("I have {0} in my bank account, and I am {1} in debt", bankAccount, debt);
            if (difference >= 7000)
            {
                Console.WriteLine("I have extra money to buy socks this month");
            }
            else if (difference < 6999 && difference > 2000)
            {
                Console.WriteLine("Well got to get rid of the Dog");
            }
            else
            {
                Console.WriteLine("Looks like im living with the rents this month");
            }
            Console.ReadLine();
        }
    }
}
