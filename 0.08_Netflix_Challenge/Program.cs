using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Netflix_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies batMan = new Movies();
            batMan.Name = "Batman";
            batMan.Genre = "Action";
            batMan.Rating = 5;
            batMan.TotalMinutes = 126;
            batMan.GetSuggestions();
            batMan.ShowRuntime();
            Console.WriteLine(batMan.ShowWhoViewed("Nathan", "4"));

            Movies dieHard = new Movies();
            dieHard.Name = "Die Hard";
            dieHard.Genre = "Action";
            dieHard.Rating = 5;
            

            

            Movies kingKong = new Movies();
            kingKong.Name = "King Kong";
            kingKong.Genre = "Romance";
            kingKong.Rating = 3;


           
            Console.WriteLine();
            Console.ReadLine();

            

    }
    }
}
