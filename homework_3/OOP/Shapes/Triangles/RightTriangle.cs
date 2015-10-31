using System.Collections.Generic;

namespace OOP.Shapes.Triangles
{
    /// <summary>
    /// Triangle with one 90 degrees corner
    /// </summary>
    public class RightTriangle : Triangle
    {
        public override string ShapeName
        {
            get { return "RightTriangle"; }
        }

        public RightTriangle() : this(new Dictionary<ParamKeys, object> { 
                {ParamKeys.Edge1, 0},
                {ParamKeys.Edge2, 0},
                {ParamKeys.Edge3, 0},
                {ParamKeys.CoordX, 0},
                {ParamKeys.CoordY, 0}
            })
        {

        }
        public RightTriangle(IDictionary<ParamKeys, object> parameters) : base(parameters)
        {
            Edge1 = (double)parameters[ParamKeys.Edge1];
            Edge2 = (double)parameters[ParamKeys.Edge2];
            Edge3 = (double)parameters[ParamKeys.Edge3];
        }

    }
}