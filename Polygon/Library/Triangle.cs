using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    public class Triangle : IRegularPolygon
    {

        #region Fields and Properties
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }
        #endregion

        #region Constructors
        public Triangle(int sideLength)
        {
            NumberOfSides = 3;
            SideLength = sideLength;
        } 
        #endregion

        #region Methods
        public double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        } 
        #endregion

    }
}
