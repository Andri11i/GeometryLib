using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Rectangle
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return 2 * (Width + Height);
        }

        public override string ToString()
        {
            return $"Rectangle with width {Width} and height {Height}";
        }
    }
}
