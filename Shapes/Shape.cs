using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public Shape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public int height;
        public int width;
        public abstract float CalculateSurface();
    }
}
