using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    public class ATriangle : AbstractRegularPolygon
    {

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="ATriangle"/> class.
        /// </summary>
        /// <param name="sideLength">Length of the side.</param>
        public ATriangle(int sideLength) : base(3, sideLength)
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
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        } 
        #endregion

    }
}
