﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height)
        {

        }

        public override float CalculateSurface()
        {
            return width * height;
        }
    }
}
