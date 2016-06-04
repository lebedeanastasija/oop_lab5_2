using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaintAPI;

namespace lab1__classes
{
    class EllipseInitializer: FigureInitializer
    {
        public override void InitializeFigure(Figure f, int x, int y)
        {
            if (x > ((Ellipse)f).Base.X)
                ((Ellipse)f).Diameter = x - ((Ellipse)f).Base.X;
            else
                ((Ellipse)f).Diameter = ((Ellipse)f).Base.X - x;
            if (y > ((Ellipse)f).Base.Y)
                ((Ellipse)f).Sub_diameter = y - ((Ellipse)f).Base.Y;
            else
                ((Ellipse)f).Sub_diameter = ((Ellipse)f).Base.Y - y;
            
        }
    }
}
