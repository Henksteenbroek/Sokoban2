using Sokoban.Model;
using Sokoban.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Controller
{
    public class MainController
    {
        Game game;
        MazeReader reader;
        InputView inputView;
        MazeView mazeView;
        public MainController()
        {
            game = new Game();
            reader = new MazeReader(game);
            reader.CreateLinks(reader.ReadMaze(4));
            mazeView = new MazeView(game);
            inputView = new InputView();
            run();
            Console.ReadLine();
        }

        public void run()
        {
            mazeView.showStartingScreen();
            reader.CreateLinks(reader.ReadMaze(inputView.getMazeNumber()));
            while (true)
            {
                mazeView.showBoard();
                int input = inputView.readInput(inputView.validInputGiven());
                if (input >= 0)
                {
                    game.moveTruck(input);
                }else if(input == -1)
                {

                }
                else
                {
                    mazeView.showStartingScreen();
                    reader.CreateLinks(reader.ReadMaze(inputView.getMazeNumber()));
                }
            }
        }
    }
}
