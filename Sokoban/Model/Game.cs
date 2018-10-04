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

        public void moveTruck(int direction)
        {
            Field Target;

            switch (direction)
            {
                case 0:
                    Target = Truck.Up;
                    break;
                case 1:
                    Target = Truck.Down;
                    break;
                case 2:
                    Target = Truck.Left;
                    break;
                case 3:
                    Target = Truck.Right;
                    break;
                default:
                    Target = Truck;
                    break;
            }
            Target.hasTruck = true;
            Truck.hasTruck = false;
            Truck.assignCharacter();
            Target.assignCharacter();
            Truck = Target;
        }

        public void moveCrate(int direction)
        {
            
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
