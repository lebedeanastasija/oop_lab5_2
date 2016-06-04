using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaintAPI;

namespace lab1__classes
{
    class BrushDrawer: FigureDrawer
    {
        public override Bitmap DrawFigure(System.Windows.Forms.PictureBox pb, Pen p, Figure f)
        {
            Bitmap b_t = new Bitmap(pb.Size.Width, pb.Size.Height);
            Graphics g = Graphics.FromImage(b_t);
            g.DrawImage(pb.Image, 0, 0);
            g.DrawEllipse(p, ((Brush)f).Base.X, ((Brush)f).Base.Y, 1, 1);
            return b_t;
        }
    }
}
