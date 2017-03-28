using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear barryTheBear = new Bear();
            barryTheBear.Weight = 2000;
            barryTheBear.Walks();
            barryTheBear.Speaks();
          

            PolarBear CokeACola = new PolarBear();

            Animal theJSWiz = new Animal();
            theJSWiz.NumberOfLegs = 2;
               

            Console.ReadLine();

        }
    }
}
