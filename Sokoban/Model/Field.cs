using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public class Field
    {
        public Field FieldUp { get; set; }
        public Field FieldDown { get; set; }
        public Field FieldLeft { get; set; }
        public Field FieldRight { get; set; }
        public int Field_x { get; set; }
        public int Field_y { get; set; }
        public Crate Crate { get; set; }
        public Truck Truck { get; set; }
        public FieldType FieldType { get; set; }
        public char FieldChar { get; set; }

        public Field(FieldType fieldType)
        {
            FieldType = fieldType;
        }

        public void removeTruck()
        {
            Truck = null;
        }

        public void removeCrate()
        {
            Crate = null;
        }

        public bool isEmpty()
        {
            if (Truck == null && Crate == null && FieldType != FieldType.wall)
            {
                return true;
            }
            return false;
        }

        public bool hasCrate()
        {
            if (Crate == null)
            {
                return false;
            }
            return true;
        }

        public bool hasTruck()
        {
            if (Truck == null)
            {
                return false;
            }
            return true;
        }

        public void assignCharacter()
        {
            if (hasTruck())
            {
                FieldChar = '@';
                return;
            }else if (hasCrate())
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
            }
        }
    }
}
