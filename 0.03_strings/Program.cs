using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //name demo

            //string firstName;
            //string lastName;
            //string occupation;

            //firstName = "Zakk";
            //lastName = "Wilde";
            //occupation = "Bringing Metal to the Children";
            //string fullName = firstName + " " + lastName;
            //Console.WriteLine(fullName);

            //String Interpolation
            //Console.WriteLine("Name: {0}" + "\n" + "Occupation: {1}", fullName, occupation);
            //Console.ReadLine();

            string dog;
            string cat;

            dog = "McGreggor";
            cat = "Lilly";

            string dogowner;
            string catowner;

            dogowner = "Dawn";
            catowner = "Nathan";
            Console.WriteLine( "{1} owns {0}\n{2} owns {3}" , dog, dogowner, catowner, cat );
            Console.ReadLine();


            Console.WriteLine()

        }
    }
}
