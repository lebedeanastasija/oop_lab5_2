using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaintAPI;

namespace lab1__classes
{
    class RectangleDrawer: FigureDrawer
    {
        public override Bitmap DrawFigure(System.Windows.Forms.PictureBox pb, Pen p, Figure f)
        {
            Bitmap b_t = new Bitmap(pb.Size.Width, pb.Size.Height);
            Graphics g = Graphics.FromImage(b_t);
            g.DrawImage(pb.Image, 0, 0);
            g.DrawRectangle(p, ((Rectangle)f).Base.X, ((Rectangle)f).Base.Y, ((Rectangle)f).Width, ((Rectangle)f).Height);
            return b_t;
        }
    }
}
