using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public Triangle(int width, int height) : base(width, height)
        {

        }
        public override float CalculateSurface()
        {
            return width * (float)height / 2;
        }
    }
}
