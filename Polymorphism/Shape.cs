using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{ 
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.Write("Draw a Rectangle");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.Write("Draw a Circle");
            //Use for execute code of base method overrided
            //base.Draw();
        }
    }

    public static class Canvas
    {
        //Shapes Behavior should be isolted in one entity class 
        
        public static void DrawShapes(List<Shape> shapes)//Upcasting
        {
            foreach (var shape in shapes)
            {
                shape.Draw();                
            }
        }
    }

    public class Posicion
    {

    }
    public class Shape
    {
        public int width { get; set; }
        public int Height { get; set; }
        public Int16 sides { get; set; }
        public Posicion Posicion { get; set; }

        public virtual void Draw()
        {
            
        }
    }
}
