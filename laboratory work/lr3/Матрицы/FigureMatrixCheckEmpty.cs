using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba2_1;

namespace lr3
{
    public class FigureMatrixCheckEmpty : IMatrixCheckEmpty<GeomFigure>
    {

        public GeomFigure getEmptyElement()
        {
            return null;
        }


        public bool checkEmptyElement(GeomFigure element)
        {
            bool Result = false;
            if (element == null)
            {
                Result = true;
            }
            return Result;
        }
    }
}
