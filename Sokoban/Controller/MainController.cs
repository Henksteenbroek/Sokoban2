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
        //InputView inputView;
        MazeView mazeView;
        public MainController()
        {
            game = new Game();
            reader = new MazeReader(game);
            reader.CreateLinks(reader.ReadMaze(4));
            mazeView = new MazeView(game);
            mazeView.showStartingScreen();
            Console.ReadLine();
        }
    }
}
