using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donuts appleCinn = new Donuts();
            appleCinn.Filling = "apple pie";
            appleCinn.isSpecial = false;
            appleCinn.Price = 0.99m;
            appleCinn.Type = "Filled";

            Console.WriteLine(appleCinn.Filling);
            //Console.ReadLine();

            Donuts longJohn = new Donuts();
            longJohn.Filling = "Bavarian Creme";
            longJohn.isSpecial = true;
            longJohn.Price = 1.2m;
            longJohn.Type = "Filled";

            Console.WriteLine(longJohn.Price);
            Console.ReadLine();
        }
    }
}
