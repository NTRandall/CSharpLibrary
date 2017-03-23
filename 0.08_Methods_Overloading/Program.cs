using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Methods_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player theJSWizard = new Player();
            theJSWizard.Name = "The self-proclaimed JS Wizard";
            theJSWizard.Attack();
            theJSWizard.Attack(" Dusty Hard Drive");
            theJSWizard.Attack(" Dusty Hard Drive", 1);
            Console.ReadLine();
        }
    }
}
