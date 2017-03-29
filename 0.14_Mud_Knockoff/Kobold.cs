using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Mud_Knockoff
{
    class Kobold : Enemy
    {
        

        Dictionary<string, int> Attacks = new Dictionary<string, int>
            {
                {"Punch", 1 },
                {"Bite", 5 },
                {"Scratch", 3 },
                
            };

        public Kobold()
        {
            this.PowerLevel = 20;
            this.Name = "Kobold";
        }

        public void koboldInsult()
        {

            ArrayList koboldinsult = new ArrayList { "ugly you", "fight fight", "Meow" };
            Random rnd = new Random();
            int ki = rnd.Next(0, koboldinsult.Count);
            Console.WriteLine("me mighty {0} you dumb {1}", this.Name, insult[ki]);
        }

        public override void Insult()
        {
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("I am {0} you {1}", this.Name, insult[r]);
        }

     

        public void KoboldAttack(Player player)
        {
            Attack(player, Attacks, this.Name);
        }
    }
}
