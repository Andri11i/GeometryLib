using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Circle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"Circle with radius {Radius}";
        }
    }
}
