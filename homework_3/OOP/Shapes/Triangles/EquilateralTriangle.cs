using System.Collections;
using System.Collections.Generic;

namespace OOP.Shapes.Triangles
{
    /// <summary>
    /// triangle where all edges are equal
    /// </summary>
    public class EquilateralTriangle : Triangle
    {
        public override string ShapeName
        {
            get { return "EquilateralTriangle"; }
        }

        public EquilateralTriangle() : this(new Dictionary<ParamKeys, object> { 
                {ParamKeys.Edge1, 0},
                {ParamKeys.Edge2, 0},
                {ParamKeys.Edge3, 0},
                {ParamKeys.CoordX, 0},
                {ParamKeys.CoordY, 0}
            })
        {

        }
        public EquilateralTriangle(IDictionary<ParamKeys, object> parameters) : base(parameters)
        {
            Edge1 = (double)parameters[ParamKeys.Edge1];
            Edge2 = (double)parameters[ParamKeys.Edge2];
            Edge3 = (double)parameters[ParamKeys.Edge3];
        }

        public override double GetPerimeter()
        {
            return Multiplier * Edge1 * 3;
        }
    }
}