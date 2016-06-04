using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaintAPI;

namespace lab1__classes
{
    class InitializerList: List<FigureInitializer>
    {
        public InitializerList()
        {
            this.Add(new BrushInitializer());
            this.Add(new LineInitializer());
            this.Add(new RectangleInitializer());
            this.Add(new SquareInitializer());
            this.Add(new EllipseInitializer());
            this.Add(new CircleInitializer());
        }
    }
}
