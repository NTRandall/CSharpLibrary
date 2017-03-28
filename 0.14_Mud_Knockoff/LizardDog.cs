using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Mud_Knockoff
{
    class LizardDog : Enemy
    {
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
       
    }

}
