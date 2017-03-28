using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Inheritance
{
    class Tiger : Animal
    {
        public bool HasTeeth { get; set; }
        public string Carnivore { get; set; }
        public string Color { get; set; }
        public bool Meow { get; set; }


        public void Thereismorethanonewaytoskinacat()
        {
            Console.WriteLine("Meow");
        }

        public void Pounce()
        {
            Console.WriteLine("The Siberian Tiger has a distinct {0}", Color );
        }
        

    }
}
