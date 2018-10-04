using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public class Game
    {
        public int Maze_x { get; set; }
        public int Maze_y { get; set; }
        public Field First { get; set; }
        public Field Last { get; set; }
        public List<Field> Crates { get; set; }
        public Field Truck { get; set; }

        public Game()
        {
            Crates = new List<Field>();
        }

        public void moveTruck(Direction direction)
        {

        }

        public void moveCrate(Direction direction)
        {

        }

        public bool hasClearPath(Direction direction)
        {
            return true;
        }

        //public bool gameFinished()
        //{
        //    foreach (Field item in Crates)
        //    {
        //        if (!item.OnGoal)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
    }
}
