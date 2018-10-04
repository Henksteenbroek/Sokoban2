using Sokoban.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.View
{
    class MazeView
    {

        Game game;

        public MazeView(Game game)
        {
            this.game = game;
        }

        public void showBoard()
        {
            Console.Clear();
            Console.WriteLine("┌──────────┐   ");
            Console.WriteLine("| Sokoban  |   ");
            Console.WriteLine("└──────────┘   ");
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");
            printFields();
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");
        }

        public void showStartingScreen()
        {
            Console.WriteLine("┌────────────────────────────────────────────────────┐");
            Console.WriteLine("| Welkom bij Sokoban                                 |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("| betekenis van de symbolen   |   doel van het spel  |");
            Console.WriteLine("|                             |                      |");
            Console.WriteLine("| spatie : outerspace         |   duw met de truck   |");
            Console.WriteLine("|      █ : muur               |   de krat(ten)       |");
            Console.WriteLine("|      · : vloer              |   naar de bestemming |");
            Console.WriteLine("|      O : krat               |                      |");
            Console.WriteLine("|      0 : krat op bestemming |                      |");
            Console.WriteLine("|      x : bestemming         |                      |");
            Console.WriteLine("|      @ : truck              |                      |");
            Console.WriteLine("└────────────────────────────────────────────────────┘" + "\n");

            Console.WriteLine("> Kies een doolhof (1 - 4), s = stop");
        }

        private void printFields()
        {
            Field temp1 = game.First;
            Field temp2 = game.First;

            while (temp1 != game.Last)
            {
                if (temp1 != null)
                {
                    Console.Write(temp1.FieldChar);
                    temp1 = temp1.Right;
                }
                else if (temp2.Down != null)
                {
                    temp1 = temp2.Down;
                    temp2 = temp2.Down;
                    Console.WriteLine();
                }
            }
            Console.WriteLine(game.Last.FieldChar);
        }

        public void gameWon()
        {
            Console.WriteLine("Hoera, je hebt dit level opgelost");
        }
    }
}
