using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bad Implementation
            var shape = new ShapeBadImplementation { ShapeType = ShapeType.Circle};
            var listShapes = new List<ShapeBadImplementation>();
            listShapes.Add(shape);
            listShapes.Add(new ShapeBadImplementation { ShapeType = ShapeType.Hexagone });
            CanvasBadImplementation.DrawShapes(listShapes);

            //Good Implementation
            //We are using Upcasting, Polymorphism, Method Overriding
            var listShapes2 = new List<Shape>();
            listShapes2.Add(new Circle()); //Upcasting
            listShapes2.Add(new Rectangle());
            Canvas.DrawShapes(listShapes2);

        }
    }
}
