using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaintAPI;

namespace lab1__classes
{
    class DrawerList: List<FigureDrawer>
    {
        public DrawerList()
        {
            this.Add(new BrushDrawer());
            this.Add(new LineDrawer());
            this.Add(new RectangleDrawer());
            this.Add(new SquareDrawer());
            this.Add(new EllipseDrawer());
            this.Add(new CircleDrawer());
        }
    }
}
