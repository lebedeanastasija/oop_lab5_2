using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaintAPI;

namespace lab1__classes
{
    class Circle: Figure
    {
        public int Diameter { set; get; }

        public Circle()
        {
            Id = 5;
        }
    }
}
