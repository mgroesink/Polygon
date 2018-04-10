using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    public class ASquare : AbstractRegularPolygon
    {

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="ASquare"/> class.
        /// </summary>
        /// <param name="length">The length.</param>
        public ASquare(int length) : base(4, length)
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
