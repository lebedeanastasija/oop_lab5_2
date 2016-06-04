using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaintAPI;

namespace lab1__classes
{
    class LineCreator: FigureCreator
    {
        public override Figure CreateFigure()
        {
            Line temp = new Line();
            temp.Base = new Point(-1, -1);
            return temp;
        }
    }
}
