using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Mud_Knockoff
{
    abstract class Enemy
    {
        protected ArrayList insult = new ArrayList { "Die", "My cat fights better than you", "The JSWizard is more of a challenge than you", "Meow" };

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

        public void Attack(Player player, Dictionary<string, int> dict, Object enemyName)
        {
                 
            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("Enemey is attacking with {0} and deals {1}", attackName, attackVal);

        Console.WriteLine("{0} health is at {1}%", player.PlayerName, player.CurrentHealth);
            player.CurrentHealth -= attackVal; // player.CurrentHealth = player.CurrentHealth - 15

        }

    }



}
