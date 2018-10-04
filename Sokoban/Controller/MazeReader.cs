using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public class MazeReader
    {
        string[] levelStrings;
        Field[,] levelFields;
        Game game;

        public MazeReader(Game game)
        {
            this.game = game;
        }

        public Field[,] ReadMaze(int mazeNumber)
        {
            int x = 0;
            int y = 0;

            levelStrings = System.IO.File.ReadAllLines(@"C:\Users\Acer\Desktop\Doolhof\doolhof" + mazeNumber + ".txt");
            levelFields = new Field[levelStrings.Length, levelStrings[x].Length];

            for (y = 0; y < levelStrings.Length; y++)
            {
                for (x = 0; x < levelStrings[y].Length; x++)
                {
                    switch (levelStrings[y][x])
                    {
                        case '#':
                            levelFields[y, x] = new Field(FieldType.wall);
                            break;
                        case '.':
                            levelFields[y, x] = new Field(FieldType.floor);
                            break;
                        case 'x':
                            levelFields[y, x] = new Field(FieldType.goal);
                            break;
                        case 'o':
                            levelFields[y, x] = new Field(FieldType.floor);
                            levelFields[y, x].hasCrate = true;
                            game.Crates.Add(levelFields[y, x]);
                            break;
                        case '@':
                            levelFields[y, x] = new Field(FieldType.floor);
                            levelFields[y, x].hasTruck = true;
                            game.Truck = levelFields[y, x];
                            break;
                        case ' ':
                            levelFields[y, x] = new Field(FieldType.space);
                            break;
                        default:
                            levelFields[y, x] = null;
                            Console.WriteLine("Unidentified char at " + x + "," + y);
                            break;
                    }

                    levelFields[y, x].Field_x = x;
                    levelFields[y, x].Field_y = y;
                    levelFields[y, x].assignCharacter();
                }
            }

            return levelFields;
        }

        public void CreateLinks(Field[,] fields)
        {
            game.First = fields[0, 0];
            game.Last = fields[fields.GetLength(0) - 1, fields.GetLength(1) - 1];

            for (int y = 0; y < fields.GetLength(0); y++)
            {
                for (int x = 0; x < fields.GetLength(1); x++)
                {
                    if (x + 1 != fields.GetLength(1) && fields[y, x + 1] != null)
                    {
                        fields[y, x].Right = fields[y, x + 1];
                        fields[y, x + 1].Left = fields[y, x];
                    }
                    if (y + 1 != fields.GetLength(0) && fields[y + 1, x] != null)
                    {
                        fields[y, x].Down = fields[y + 1, x];
                        fields[y + 1, x].Up = fields[y, x];
                    }
                }
            }

        }

    }
}
