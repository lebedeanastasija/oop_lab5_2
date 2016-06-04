using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaintAPI;

namespace lab1__classes
{
    class SquareInitializer:FigureInitializer
    {
        public override void InitializeFigure(Figure f, int x, int y)
        {
            if (x > ((Square)f).Base.X)
            {
                ((Square)f).Width = x - ((Square)f).Base.X;
            }
            else
            {
                ((Square)f).Width = ((Square)f).Base.X - x;
            }
        }
    }
}
