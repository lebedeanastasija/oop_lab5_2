using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaintAPI;

namespace lab1__classes
{
    class Ellipse:Circle
    {
        public int Sub_diameter {set; get;}

        public Ellipse() 
        {
            Id = 4;
        }
    }
}
