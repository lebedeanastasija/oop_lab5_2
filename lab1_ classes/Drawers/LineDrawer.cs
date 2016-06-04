using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaintAPI;

namespace lab1__classes
{
    class LineDrawer: FigureDrawer
    {
        public override Bitmap DrawFigure(System.Windows.Forms.PictureBox pb, Pen p, Figure f)
        {
            Bitmap b_t = new Bitmap(pb.Size.Width, pb.Size.Height);
            Graphics g = Graphics.FromImage(b_t);
            g.DrawImage(pb.Image, 0, 0);
            g.DrawLine(p, ((Line)f).Base.X, ((Line)f).Base.Y, ((Line)f).Dot.X, ((Line)f).Dot.Y);
            return b_t;  
        }
    }
}
