using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaintAPI;

namespace lab1__classes
{
    class CircleCreator:FigureCreator
    {
        public override Figure CreateFigure()
        {
            Circle temp = new Circle();
            temp.Base = new Point(-1, -1);
            return new Circle();
        }
    }
}
