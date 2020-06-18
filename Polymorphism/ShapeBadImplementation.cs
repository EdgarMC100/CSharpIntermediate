 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{ 

    public static class CanvasBadImplementation
    {

        //Shapes Behavior should be isolted in one entity class
        public static void DrawShapes(List<ShapeBadImplementation> shapes)
        {
            foreach (var shape in shapes)
            {
                switch (shape.ShapeType)
                {
                    //This is a bad implementation because is a fat code.
                    case ShapeType.Circle:
                        Console.Write("Draw a Circle");
                        break;
                    case ShapeType.Rectangle:
                        Console.Write("Draw a Rectangle");
                        break;
                    case ShapeType.Square:
                        Console.Write("Draw a Square");
                        break;
                    case ShapeType.Triangle:
                        Console.Write("Draw a Triangle");
                        break;
                    case ShapeType.Hexagone:
                        Console.Write("Draw a Hexagone");
                        break;
                    default:
                        Console.Write("No Shape to Draw");
                        break;
                }
            }
        }
    }
    public enum ShapeType
    {
        Circle,
        Rectangle,
        Square,
        Triangle,
        Hexagone
    }
    public class Position
    {

    }
    public class ShapeBadImplementation
    {
        public int width { get; set; }
        public int Height { get; set; }
        public Int16 sides { get; set; }
        public Position Position { get; set; }
        public ShapeType ShapeType { get; set; }
    }
}
