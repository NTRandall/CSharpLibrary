using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevatorUp = true;
            bool elevatorDown = true;
            bool elevatorBroken = true;
            bool elevatorStuck = true;
            int floorNumber = 13;

            if (elevatorUp == true)
            {
                //Do stuff
                Console.WriteLine("Going up");
            }
            if (elevatorDown)
            {
                //Do something else
                Console.WriteLine("Going down");
            }                                       
            if (elevatorBroken)
            {
                Console.WriteLine("Panic!");                                  
            }
            if (elevatorStuck)
            {
                Console.WriteLine("Hmm");
            }
            if (elevatorBroken && elevatorDown)
            {
                Console.WriteLine("Weeeeee!");
            }

            if (elevatorStuck)
            {
                Console.WriteLine("man, I wish");
            }
            if (elevatorBroken || elevatorStuck)
            {
                Console.WriteLine("Dude");
            }
            if (floorNumber == 13 && elevatorStuck)
                    {
                Console.WriteLine("we're all going to die");
            }
                Console.ReadLine();
        }
    }
}
