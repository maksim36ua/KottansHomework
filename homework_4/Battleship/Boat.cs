using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public enum Direction
    {
        Vertiacal,
        Horizontal
    }

    public class Boat
    {
        protected int x;
        protected int y;
        protected Direction direction;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Direction Direct
        {
            get { return direction; }
            set { direction = value; }
        }

        public Boat(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direct = direction;
        }

    }
}
