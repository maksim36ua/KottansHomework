using System;
using System.Collections.Generic;

namespace OOP.Shapes
{
    // TODO: use Heron's formula for area
    public class Triangle : ShapeBase
    {
        protected double Edge1, Edge2, Edge3;
        protected double Perimeter;

        public override string ShapeName
        {
            get { return "Triangle"; }
        }

        public Triangle() : this(new Dictionary<ParamKeys, object> { 
                {ParamKeys.Edge1, 0},
                {ParamKeys.Edge2, 0},
                {ParamKeys.Edge3, 0},
                {ParamKeys.CoordX, 0},
                {ParamKeys.CoordY, 0}
            })
        {

        }

        public Triangle(IDictionary<ParamKeys, object> parameters) : base(parameters)
        {
            Edge1 = (double)parameters[ParamKeys.Edge1];
            Edge2 = (double)parameters[ParamKeys.Edge2];
            Edge3 = (double)parameters[ParamKeys.Edge3];

        }

        protected override double Area()
        {
            double p = GetPerimeter()/2;
            return Math.Sqrt(p * (p - this.Edge1 * Multiplier) * (p - this.Edge2 * Multiplier) * (p - this.Edge3 * Multiplier));
        }


        public override double GetPerimeter()
        {
            return (Edge1 + Edge2 + Edge3) * Multiplier;
        }

        public override void Move(int deltaX, int deltaY)
        {
            this.CoordX += deltaX;
            this.CoordY += deltaY;
        }

    }
}