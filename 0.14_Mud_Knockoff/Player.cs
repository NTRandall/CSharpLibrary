using System;
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
        public string PlayerName { get; set; }
        public string Clan { get; set; }
        public int CurrentPower { get; set; }
        public CharacterType Type { get; set; }

        public Player(string name, string clanName, CharacterType type =CharacterType.Figter)
        {
            this.PlayerName = name;
            this.Clan = clanName;
            this.CurrentPower = 100;
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
            Console.WriteLine("{0}'s power level is at {1}", this.PlayerName, this.CurrentPower);
        }

        public void BattleCry()
        {
            Console.WriteLine("God save the Queen!!");
        }
        
        public override string ToString()
        {
            return $"Player Name: {this.PlayerName}\nClan Name: {this.Clan}\nPlayer Type: {this.Type}\nStarting Health: {this.CurrentPower}";
        }

    }
}
