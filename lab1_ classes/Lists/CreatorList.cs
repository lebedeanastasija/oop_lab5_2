using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaintAPI;

namespace lab1__classes
{
    class CreatorList: List<FigureCreator>
    {
        public CreatorList()
        {
            this.Add(new BrushCreator());
            this.Add(new LineCreator());
            this.Add(new RectangleCreator());
            this.Add(new SquareCreator());
            this.Add(new EllipseCreator());
            this.Add(new CircleCreator());
        }
    }
}
