using System;
using System.Collections.Generic;

namespace OOP.Shapes

{
    public class Rectangle : ShapeBase
    {
        private readonly double Edge1, Edge2;

        public override string ShapeName
        {
            get { return "Rectangle"; }
        }

        public Rectangle() : this(new Dictionary<ParamKeys, object> { 
                {ParamKeys.Edge1, 0},
                {ParamKeys.Edge2, 0},
                {ParamKeys.CoordX, 0},
                {ParamKeys.CoordY, 0}
            })
        {

        }

        public Rectangle(IDictionary<ParamKeys, object> parameters) : base(parameters)
        {
            Edge1 = (double) parameters[ParamKeys.Edge1];
            Edge2 = (double) parameters[ParamKeys.Edge2];

        }

        protected override double Area()
        {
            return Edge1 * Edge2 * Math.Pow(Multiplier, 2);
        } 


        public override double GetPerimeter()
        {
            return (Edge1 + Edge2) * 2 * Multiplier;
        }

        public override void Move(int deltaX, int deltaY)
        {
            this.CoordX += deltaX;
            this.CoordY += deltaY;
        }

    }
}