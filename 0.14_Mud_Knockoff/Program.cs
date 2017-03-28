using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Mud_Knockoff
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Players Name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your clan name?");
            string clan = Console.ReadLine();
            Console.WriteLine("What is your player type?\n" +
                               "0:  Assasin\n" +
                                "1: Figter\n" +
                                  "2  Mage\n" + 
                                   "3 Cleric\n" +
                                     "4 Druid\n" + 
                                      "5 TaxMan");

            int playerType = int.Parse(Console.ReadLine());
            Player player = new Player(name, clan);
            player.ChooseType(playerType);

            Console.WriteLine(player.ToString());


            LizardDog lizardDog = new LizardDog();

            lizardDog.Insult();


            //Player player = new Player(name, clan);
            //player.ChooseType(playerType);

            //Console.WriteLine(player.CurrentPower);
            //player.PowerLevelCheck();
            //player.ChooseType(0);
            //Console.WriteLine(player.ToString());

            //Enemy Jenn = new Enemy();
            //Jenn.Insult();
            Console.ReadLine();
        }
    }
}
