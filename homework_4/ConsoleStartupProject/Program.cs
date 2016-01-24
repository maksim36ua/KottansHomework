using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleship;

namespace ConsoleStartupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var ship1 = new PatrolBoat(x: 1, y: 2, direction: Direction.Horizontal);
            var ship2 = new PatrolBoat(x: 1, y: 2, direction: Direction.Vertiacal);
            Console.WriteLine(ship1.X + " " + ship2.X);
            Console.WriteLine(ship1.Y + " " + ship2.Y);
            Console.WriteLine(ship1.Direct + " " + ship2.Direct);
            Console.Read();
        }
    }
}
