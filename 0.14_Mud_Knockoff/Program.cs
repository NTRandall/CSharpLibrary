using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Mud_Knockoff
{
 
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer talkingConsole = new SpeechSynthesizer();
            //talkingConsole.Speak("Would you like to play a game?");

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
            Console.WriteLine("Kneel before Zod. Y/N");

            while (true)
            {
                
                string userAnswer = Console.ReadLine();
                if (userAnswer == "y")
                {
                    Console.WriteLine("Pathetic. I always knew your kind was weak. DIE!!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    lizardDog.LizzardAttack(player);
                    Console.WriteLine(player.CurrentHealth);
                }
                        if (player.CurrentHealth <=0)
                        {
                            Console.WriteLine("your rotting corpse feeds the crows.");
                            Console.ReadLine();
                            break;
                        }
               else
                {
                    player.BattleCry();
                    player.PlayerAttack(lizardDog);
                    Console.WriteLine(lizardDog.PowerLevel);
                }      
                        if (lizardDog.PowerLevel <-5)
                             {
                    Console.WriteLine("I yield, you are the superior fighter");
                    Console.ReadLine();
                    break;
                             }
          }
        }
    }
}
