using System;
using System.Collections.Generic;
namespace OOP.Shapes
{
	public class Circle : ShapeBase
	{
	    private readonly double Radius;

	    public override string ShapeName
        {
            get { return "Circle"; }
        }

        public Circle(double radius)
            : this(new Dictionary<ParamKeys, object> { 
                {ParamKeys.Radius, radius},
                {ParamKeys.CoordX, 0},
                {ParamKeys.CoordY, 0}
            })
        {
            Radius = radius;
        }

		public Circle(IDictionary<ParamKeys, object> parameters) : base(parameters)
		{
            Radius = (double) parameters[ParamKeys.Radius];
        }

        protected override double Area()
        {
            return Math.Pow(Radius * Multiplier, 2) * Math.PI;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius * Multiplier;
        }

        public override void Move(int deltaX, int deltaY)
        {
            CoordX += deltaX;
            CoordY += deltaY;
        }

    }
}