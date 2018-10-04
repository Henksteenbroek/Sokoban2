﻿using Sokoban.Model;
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

        public void printFields()
        {
            Field temp1 = game.First;
            Field temp2 = game.First;

            while (temp1 != game.Last)
            {
                if (temp1 != null)
                {
                    Console.Write(temp1.FieldChar);
                    temp1 = temp1.FieldRight;
                }
                else if (temp2.FieldDown != null)
                {
                    temp1 = temp2.FieldDown;
                    temp2 = temp2.FieldDown;
                    Console.WriteLine();
                }
            }
            Console.WriteLine(game.Last.FieldChar);
        }
    }
}