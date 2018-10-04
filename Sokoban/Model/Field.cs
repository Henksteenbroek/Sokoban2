using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public class Field
    {
        public Field Up { get; set; }
        public Field FieldDown { get; set; }
        public Field FieldLeft { get; set; }
        public Field FieldRight { get; set; }
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
            if (Truck == null && Crate == null && FieldType != FieldType.wall)
            {
                return true;
            }
            return false;
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
