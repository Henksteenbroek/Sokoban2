namespace Sokoban.Model
{
    public class MoveableObject
    {
        public Field Location { get; set }

        public void move(Direction direction)
        {
            switch (direction)
            {
                case Direction.up:

                    break;
                case Direction.down:
                    break;
                case Direction.left:
                    break;
                case Direction.right:
                    break;
            }
        }

        public void canMove()
        {

        }
    }
}