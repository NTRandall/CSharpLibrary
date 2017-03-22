using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please enter your name");
            string friend = Console.ReadLine();

            switch (friend)
            {
                case "Chris":
                    
                        Console.WriteLine("Hey Fred");
                        break;
                    
                case "Sergei":
                    
                        Console.WriteLine("Hey Sergei");
                        break;

                case "Matt":

                    Console.WriteLine("Hey Sergei");
                    break;
                case "George":

                    Console.WriteLine("Hey Sergei");
                    break;
                case "Paul":

                    Console.WriteLine("Hey Sergei");
                    break;

                default:
                    Console.WriteLine("Say Friend to enter");
                        break;
                    
            }
            Console.ReadLine();

        }
    }
}
