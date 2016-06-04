using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1__classes
{
    [Serializable]
    public class ImageInfo
    {
        public byte[] Image { get; set; }
        public DateTime Date { get; set; }
    }
}
