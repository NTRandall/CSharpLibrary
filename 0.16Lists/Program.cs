using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "James", "Paul", "Kenn", "Jenn", "L"
            };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            names.Add("Nathan");
            Console.WriteLine("==============");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            names.Remove("Jenn");
            Console.WriteLine("================");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("==================");
            Console.WriteLine("Lambda expressions with .ForEach");
            names.ForEach(name => Console.WriteLine(name));
            Console.ReadLine();
        }
    }
}
