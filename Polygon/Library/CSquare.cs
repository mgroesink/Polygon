using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    public class CSquare : ConcreteRegularPolygon
    {

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="CSquare"/> class.
        /// </summary>
        /// <param name="sideLength">Length of the side.</param>
        public CSquare(int sideLength) : base(4, sideLength)
        {
        }

        #endregion

        #region Methods
        /// <summary>
        /// Gets the area.
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return Math.Pow(SideLength, 2);
        } 
        #endregion

    }
}
