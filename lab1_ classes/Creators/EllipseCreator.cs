using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaintAPI;

namespace lab1__classes
{
    class EllipseCreator:FigureCreator
    {
        public override Figure CreateFigure()
        {
            Ellipse temp = new Ellipse();
            temp.Base = new Point(-1, -1);
            return new Ellipse();     
        }
    }
}
