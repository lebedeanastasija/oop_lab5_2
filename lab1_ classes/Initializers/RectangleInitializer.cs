using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaintAPI;

namespace lab1__classes
{
    class RectangleInitializer:FigureInitializer
    {
        public override void InitializeFigure(Figure f, int x, int y)
        {
            if (x > ((Rectangle)f).Base.X)
            {
                ((Rectangle)f).Width = x - ((Rectangle)f).Base.X;
            }
            else
            {
                ((Rectangle)f).Width = ((Rectangle)f).Base.X - x;
            }
            if (y > ((Rectangle)f).Base.Y)
            {
                ((Rectangle)f).Height = y - ((Rectangle)f).Base.Y;
            }
            else
            {
                ((Rectangle)f).Height = ((Rectangle)f).Base.Y - y;
            }
        }
    }
}
