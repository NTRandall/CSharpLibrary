using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Mud_Knockoff
{
    class Enemy
    {
        protected ArrayList insult = new ArrayList { "Did you get that TPS report?", "Don't be late for the meeting", "H.R. needs to see you", "Meow" };

        protected Random rnd = new Random();
        public string Name { get; set; }
        public int PowerLevel { get; set; }
       
        public virtual void Insult()
        {

           //// ArrayList insult = new ArrayList { "Did you get that TPS report?", "Don't be late for the meeting", "H.R. needs to see you", "Meow" };
           // insult.Add("four-eyes");
           // Random rnd = new Random();
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("{0}", insult[r]);
        }



    }



}
