using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class PatrolBoat : Boat
    {
        public PatrolBoat(int x, int y, Direction direction = Direction.Horizontal) : base(x, y, direction)
        {
        }
    }
}
