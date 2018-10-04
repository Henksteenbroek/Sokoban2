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

        }

        public void moveCrate(int direction)
        {

        }

        public bool gameFinished()
        {
            Field temp1 = First;
            Field temp2 = First;

            while (temp1 != Last)
            {
                if (temp1 != null && temp1.hasCrate && temp1.FieldType != FieldType.goal)
                {
                    return false;
                }
                else if (temp2.Down != null)
                {
                    temp1 = temp2.Down;
                    temp2 = temp2.Down;
                }
            }
            return true;
        }
    }
}
