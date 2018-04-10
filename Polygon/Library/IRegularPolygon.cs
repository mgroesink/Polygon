using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    public interface IRegularPolygon
    {

        #region Properties
        int NumberOfSides { get; set; }

        int SideLength { get; set; }
        #endregion

        #region Methods
        double GetArea();
        double GetPerimeter(); 
        #endregion

    }
}
