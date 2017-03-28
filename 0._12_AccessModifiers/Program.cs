using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Acura TL = new Acura("TL", 2000, 500);
            TL.price = 1000;
            Console.WriteLine(TL.AcuraDetails());
            Console.ReadLine();
        }

    }
}
