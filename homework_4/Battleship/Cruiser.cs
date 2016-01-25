using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Cruiser : Boat
    {

        public Cruiser(int x, int y, Direction direction = Direction.Horizontal) : base (x, y, direction)
        {
        }
    }
}
