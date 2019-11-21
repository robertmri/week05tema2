using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        public Square(int width) : base(width, width)
        {

        }
        public override float CalculateSurface()
        {
            return width * width;
        }
    }
}
