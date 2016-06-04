using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaintAPI;

namespace lab1__classes
{
    class SquareCreator: FigureCreator
    {
        public override Figure CreateFigure()
        {
            Square temp = new Square();
            temp.Base = new Point(-1, -1);
            return temp;            
        }
    }
}
