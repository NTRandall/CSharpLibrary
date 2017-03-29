//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Speech.Synthesis;
//using System.Text;
//using System.Threading.Tasks;

//namespace _0._14_Mud_Knockoff
//{
//    class Fighter: Player
//    {
//        Dictionary<string, int> Attacks = new Dictionary<string, int>
//            {
//                {"Head-butt", 5 },
//                {"Bite", 10 },
//                {"Charge", 8 },
//                {"Trip", 12 },
//            };

//        public Fighter()
//        {
//            this.PowerLevel = 40;
//            this.Name = "";
//        }

//        public override void Insult()
//        {
//            int r = rnd.Next(0, insult.Count);
//            Console.WriteLine("I am {0} you {1}", this.Name, insult[r]);
//        }

//        public void FighterAttack(Player player)
//        {
//            FighterAttack(player, Attacks, this.Name);
//        }
//    }
//}
