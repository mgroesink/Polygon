using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    public abstract class AbstractRegularPolygon
    {

        #region Fields and Properties
        /// <summary>
        /// Gets or sets the number of sides.
        /// </summary>
        /// <value>
        /// The number of sides.
        /// </value>
        public int NumberOfSides { get; set; }
        /// <summary>
        /// Gets or sets the length of the side.
        /// </summary>
        /// <value>
        /// The length of the side.
        /// </value>
        public int SideLength { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractRegularPolygon"/> class.
        /// </summary>
        /// <param name="numberOfSides">The number of sides.</param>
        /// <param name="sideLength">Length of the side.</param>
        public AbstractRegularPolygon(int numberOfSides, int sideLength)
        {
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets the perimeter.
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        /// <summary>
        /// Gets the area.
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();
        #endregion

    }
}
