using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Mud_Knockoff
{
    public enum CharacterType
    {
        Assasin = 0,
        Figter = 1,
        Mage = 2,
        Cleric = 3,
        Druid = 4 ,
        TaxMan = 5
    }
    class Player
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


        Dictionary<string, int> Attacks = new Dictionary<string, int>
            {
                {"Head-butt", 5 },
                {"Sword Slash", 10 },
                {"Cleave", 20 },
                {"Trip", 12 },
            };
        public void PlayerAttack(LizardDog lizard)
        {
            Attack(lizard, Attacks, this.PlayerName);
        }
        public void Attack(LizardDog lizard, Dictionary<string, int> dict, object Playername)
        {

            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("{0} is attacking with {1} and deals {2}", PlayerName, attackName, attackVal);

            Console.WriteLine("{0} health is at {1}%", lizard, lizard.PowerLevel);
            lizard.PowerLevel -= attackVal; // player.CurrentHealth = player.CurrentHealth - 15

        }
        public string PlayerName { get; set; }
        public string Clan { get; set; }
        public int CurrentHealth { get; set; }
        public CharacterType Type { get; set; }

        public Player(string name, string clanName, CharacterType type =CharacterType.Figter)
        {
            this.PlayerName = name;
            this.Clan = clanName;
            this.CurrentHealth = 100;
            this.Type = type;
        }

        public CharacterType ChooseType(int t)
        {
            switch (t)
            {
                case 0:
                    Console.WriteLine("You are a Assasin");
                    return this.Type = CharacterType.Assasin;

                case 1:
                    Console.WriteLine("You are a Fighter");
                    return this.Type = CharacterType.Figter;
                case 2:
                    Console.WriteLine("You are a Mage");
                    return this.Type = CharacterType.Mage;
                case 3:
                    Console.WriteLine("You are a Cleric");
                    return this.Type = CharacterType.Cleric;
                case 4:
                    Console.WriteLine("You are a Druid");
                    return this.Type = CharacterType.Druid;
                case 5:
                    Console.WriteLine("You are a TaxMan");
                    return this.Type = CharacterType.TaxMan;
                default:
                    Console.WriteLine("You are a Fighter");
                    return this.Type = CharacterType.Figter;
            }

          

        }
        public void PowerLevelCheck()
        {
            Console.WriteLine("{0}'s power level is at {1}", this.PlayerName, this.CurrentHealth);
        }
     

        public void BattleCry()
        {
            Console.WriteLine("God save the Queen!!");
        }
        
        public override string ToString()
        {
            return $"Player Name: {this.PlayerName}\nClan Name: {this.Clan}\nPlayer Type: {this.Type}\nStarting Health: {this.CurrentHealth}";
        }

       
    }
}
