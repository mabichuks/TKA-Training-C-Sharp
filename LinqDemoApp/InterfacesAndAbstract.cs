using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemoApp
{
    public interface IShape
    {
        decimal CalculateArea();
        decimal CalculatePerimeter();
    }

    public class Square : IShape
    {
        public decimal SideLength { get; set; }

        public Square(decimal sideLength)
        {
            SideLength = sideLength;
        }

        public decimal CalculateArea()
        {
            return SideLength * SideLength;
        }

        public decimal CalculatePerimeter()
        {
            return SideLength * 4;
        }
    }

    public class Circle : IShape
    {
        public decimal Radius { get; set; }
        public decimal CalculateArea()
        {
            throw new NotImplementedException();
        }

        public decimal CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class ShapeBase
    {
        public decimal Width { get; set; }
        public abstract void CalculateArea();

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape with width: " + Width);
        }

        public class SquareShape : ShapeBase
        {
            public override void CalculateArea()
            {
                var area = Width * Width;
            }

            public override void Draw()
            {
                Console.WriteLine("Drawing a square with width: " + Width);
            }
        }
    }
}
