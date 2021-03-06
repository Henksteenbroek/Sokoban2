﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public class Field
    {
        public Field Up { get; set; }
        public Field Down { get; set; }
        public Field Left { get; set; }
        public Field Right { get; set; }
        public int Field_x { get; set; }
        public int Field_y { get; set; }
        public bool hasCrate { get; set; }
        public bool hasTruck { get; set; }
        public FieldType FieldType { get; set; }
        public char FieldChar { get; set; }

        public Field(FieldType fieldType)
        {
            FieldType = fieldType;
        }

        public void removeTruck()
        {
            hasTruck = false;
        }

        public void removeCrate()
        {
            hasCrate = false;
        }

        public bool isEmpty()
        {
            if (hasTruck == false && hasCrate == false && FieldType != FieldType.wall)
            {
                return true;
            }
            return false;
        }

        public bool hasClearPath(int direction)
        { 
            switch(direction)
            {
                case 0:
                    if (this.Up.isEmpty())
                        return true;
                    break;
                case 1:
                    if (this.Down.isEmpty())
                        return true;
                    break;
                case 2:
                    if (this.Left.isEmpty())
                        return true;
                    break;
                case 3:
                    if (this.Right.isEmpty())
                        return true;
                    break;
            }

            return false;
        }


        public void assignCharacter()
        {
            if (hasTruck == true)
            {
                FieldChar = '@';
                return;
            }else if (hasCrate == true)
            {
                FieldChar = 'O';
                return;
            }
            switch (FieldType)
            {
                case FieldType.floor:
                    FieldChar = '.';
                    break;
                case FieldType.goal:
                    FieldChar = 'x';
                    break;
                case FieldType.wall:
                    FieldChar = '█';
                    break;
                case FieldType.space:
                    FieldChar = ' ';
                    break;
            }
        }
    }
}
