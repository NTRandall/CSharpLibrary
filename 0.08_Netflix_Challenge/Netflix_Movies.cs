using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Netflix_Challenge
{
    class Movies
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public int TotalMinutes { get; set; }

        /// <summary>
        /// Methods wiht no return.
        /// </summary>

        public void GetSuggestions()
        {
            if (Rating >= 4)

                Console.WriteLine("Yo watch this!");
            else
                Console.WriteLine("Sucks.");

        }



        /// <summary>
        /// Methods that return a value.
        /// </summary>
        /// <returns></returns>

        public int ShowRuntime()
        {
            Console.WriteLine(this.Name + " is " + this.TotalMinutes + " minutes long.");
            return this.TotalMinutes;
        }


        ///Methods that have parameters
        

        public string ShowWhoViewed(string user, string time)
        {
            string details = user + " watched this at " + time;
            Console.WriteLine(details);
            return details;

        }

        public int ShowNumberOfMinutesLeft(int minutesViewed)
        {
        int numMinutesLeft = this.TotalMinutes - minutesViewed;
            Console.WriteLine("There are " + numMinutesLeft + " minutes left in " + this.Name);
            return numMinutesLeft;
         }
    }
}
