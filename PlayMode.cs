using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;


namespace TheSims
{
    internal class PlayMode
    {
        

        public void PlayMenu(bool Home, bool Fam)
        {
            Console.Clear();
            while (true)
            {
                
                Console.WriteLine("You are entering play mode!");
                Console.ReadKey();
                if (Home == true && Fam == true)
                {
                    Game();
                }
                else
                {
                    Console.WriteLine("please make a family and house before you play!");
                    Console.ReadKey();
                    break;
                }

            }

        }



        public void Game()
        {
            bool PlayingGame = true;
            Sim ChooseSim;
            while (PlayingGame)
            {
                Console.WriteLine("Here is your family");
                Family.PrintFamily();

                Console.WriteLine("Please write the name of the Sim you will play ass");
                string WrittenName = Console.ReadLine();
                

            }
        }

    }
}
