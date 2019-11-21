using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(1, 3);
            var rectangle = new Rectangle(2, 5);
            var square = new Square(8);
            List<Shape> shapes = new List<Shape>();
            shapes.Add(triangle);
            shapes.Add(rectangle);
            shapes.Add(square);

            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name} area is {shape.CalculateSurface()}");
            }
        }
    }
}
