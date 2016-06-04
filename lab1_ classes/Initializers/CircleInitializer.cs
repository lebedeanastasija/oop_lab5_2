using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaintAPI;

namespace lab1__classes
{
    class CircleInitializer:FigureInitializer
    {
        public override void InitializeFigure(Figure f, int x, int y)
        {
            if (x > ((Circle)f).Base.X)
                ((Circle)f).Diameter = x - ((Circle)f).Base.X;
            else
                ((Circle)f).Diameter = ((Circle)f).Base.X - x;
        }
    }
}
