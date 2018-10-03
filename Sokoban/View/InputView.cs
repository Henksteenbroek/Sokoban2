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

        public InputView()
        {

        }
        public void readInput()
        {
            while (true)
            {
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Up");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Down");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Left");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Right");
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine("R");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("S");
                        break;
                }
            }
        }

    }
}
