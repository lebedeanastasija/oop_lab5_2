using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaintAPI;

namespace lab1__classes
{
    class Rectangle: Square
    {
        public int Height {get; set;}

        public Rectangle()
        {
            Id = 2;
        }
    }
}
