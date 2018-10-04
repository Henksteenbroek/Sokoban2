using Sokoban.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.View
{
    public class InputView
    {
        ConsoleKeyInfo key;
        int returnValue;

        public InputView()
        {

        }

        public int readInput()
        {
            bool validInputGiven = false;

            Console.WriteLine("> gebruik pijltjestoetsen (s = stop, r = reset)");
            while (!validInputGiven)
            {
                key = Console.ReadKey();
                if (key.Key != ConsoleKey.UpArrow && key.Key != ConsoleKey.DownArrow && key.Key != ConsoleKey.LeftArrow && key.Key != ConsoleKey.RightArrow && key.Key != ConsoleKey.S && key.Key != ConsoleKey.R)
                {
                    Console.WriteLine("Gebruik alleen de pijltjestoetsen of 's' of 'r'");
                }
                else
                {
                    validInputGiven = true;
                }
            }

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    returnValue = (int)Direction.up;
                    break;
                case ConsoleKey.DownArrow:
                    returnValue = (int)Direction.down;
                    break;
                case ConsoleKey.LeftArrow:
                    returnValue = (int)Direction.left;
                    break;
                case ConsoleKey.RightArrow:
                    returnValue = (int)Direction.right;
                    break;
                case ConsoleKey.R:
                    returnValue = -1;
                    break;
                case ConsoleKey.S:
                    returnValue = -2;
                    break;
            }
            return returnValue;
        }
    }
}
