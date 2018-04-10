using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    public class Square : IRegularPolygon
    {

        #region Fileds and Properties
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }
        #endregion

        #region Constructors
        public Square(int sideLength)
        {
            NumberOfSides = 4;
            SideLength = sideLength;
        } 
        #endregion

        #region Methods
        public double GetArea()
        {
            return Math.Pow(SideLength, 2);
        }

        public double GetPerimeter()
        {
            
            return SideLength * NumberOfSides;
        } 
        #endregion

    }
}
