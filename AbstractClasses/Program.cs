using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
            //base.Draw();
        }
    }
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

    }
    class Program
    {
        static void Main(string[] args)
        {
            //var circle = new Circle();
            //circle.Draw();

            //var rectangle = new Rectangle();
            //rectangle.Draw();
            var dbCommand = new DbCommand(new OracleConnection(), "Select * from employees");
            //var dbCommand = new DbCommand(new SqlConnection(), "Select * from products  as p where o.id = 1");
            dbCommand.Execute();

        }
    }
}
