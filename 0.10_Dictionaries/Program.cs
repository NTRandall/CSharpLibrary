using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {              //key  || Value
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //dictionary.Add("cat", "annoying creature");
            //dictionary.Add("dog", "man's best friend");

            //foreach (KeyValuePair<string, string> pair in dictionary)
            //{
            //    Console.WriteLine("{0} is a {1}", pair.Key, pair.Value);
            //}
            //Console.ReadLine();

            Dictionary<string, string> acadameyawardwinners = new Dictionary<string, string>()
            {
            { "2000", "gladiator" },
            { "2001", "a beautiful mind"},
            {"2002", "chicago"},
            {"2003", "the lord of the rings: the return of the king"},
            {"2004", "million dollar baby"},
            {"2005", "crash"}
        };
            //foreach (KeyValuePair<string, string> pair in acadameyawardwinners)
            //{
            //    Console.WriteLine("{0} the acadamey award for best picture went to {1}", pair.Key, pair.Value);
            //}
            //Console.ReadLine();


            //var bestPictureNominees = new Dictionary<string, string[]>();


            //{
            //    { "2000", new string[] ( "Gladiator", "Chocolat", "Crouching Tiger, Hidden Dragon", "Erin Brokovich", "Traffic" }
            //    { "2001", new string[] { "A Beautiful Mind", "Paul", "Obi Wan", "Anakin", "Meow" } }
            //}


            Dictionary<string, string[]> bestPictures = new Dictionary<string, string[]>();


            {
                bestPictures.Add("2000", new string[] { "Gladiator", "Chocolat", "Crouching Tiger, Hidden Dragon", "Erin Brokovich", "Traffic" });
                bestPictures.Add("2001", new string[] { "A Beautiful Mind", "Paul", "Obi Wan", "Anakin", "Meow" });
                bestPictures.Add("2002", new string[] { "A Beautiful Mind", "Paul", "Obi Wan", "Anakin", "Meow" });

            }

            Console.WriteLine("Please type a year to show the movie that won:");
            string input1 = Console.ReadLine();

            //if (acadameyawardwinners.ContainsKey(input1))
            //{
            //    string valueForKey = acadameyawardwinners[input1];
            //    Console.WriteLine("The best picture in " + input1  + " was " + valueForKey);
            //}



            //foreach (KeyValuePair<string, string[]> bestPicture in bestPictures)
            //{
            //    Console.WriteLine("{0} : {1}, {2}, {3} ", bestPicture.Key, bestPicture.Value[0], bestPicture.Value[1], bestPicture.Value[2]);

            if (acadameyawardwinners.ContainsKey(input1))
            {
                string value_For_Key = acadameyawardwinners[input1];
                Console.WriteLine("The best picture in " + input1 + " was " + value_For_Key);
            }

            Console.WriteLine("Please type a year to show the movies that were up for an award that year: ");
            string readLineTwo = Console.ReadLine();

            if (acadameyawardwinners.ContainsKey(input1))
            {

                string[] value_For_Key = bestPictures[input1];
                string s = string.Join(", ", value_For_Key);
                Console.WriteLine("The best nominees in " + input1 + " were " + s);
            }
            Console.ReadLine();


        }
    }
}
