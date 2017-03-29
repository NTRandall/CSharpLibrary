using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Mud_Knockoff
{
    class LizardDog : Enemy
    {
        Dictionary<string, int> Attacks = new Dictionary<string, int>
            {
                {"Head-butt", 5 },
                {"Bite", 10 },
                {"Charge", 8 },
                {"Trip", 12 },
            };

        public LizardDog()
        {
            this.PowerLevel = 40;
            this.Name = "Lizard Dog";
        }

        public override void Insult()
        {
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("I am {0} you {1}", this.Name, insult[r]);
        }

        public void LizzardAttack(Player player)
        {
            Attack(player, Attacks, this.Name);
        }
       
    }

}
