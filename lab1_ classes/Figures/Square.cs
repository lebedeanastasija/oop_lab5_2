using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaintAPI;

namespace lab1__classes
{
    class Square: Figure
    {
        public Square()
        {
            Id = 3;
        }

        public int Width {set; get;}
    }
}
