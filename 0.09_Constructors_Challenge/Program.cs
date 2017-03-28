using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone myPhone = new MobilePhone("Apple", "Iphone 6" , "Paul");

            myPhone.PrintToScreen();
            Console.ReadLine();
        }
    }
}
