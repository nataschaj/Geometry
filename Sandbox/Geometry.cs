using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class Geometry
    {
        //constructor
        public Geometry()
        {
        }

        public double CalculateRectanglePerimeter(double sideA, double sideB)
        {
            double perimeter = 2 * sideA + 2 * sideB;
            return perimeter;
        }

        public double CalculateRectangleArea(double sideA, double sideB)
        {
            double area = sideA * sideB;
            return area;
        }

        public double CalculateCircleArea(double radius)
        {
            double radius = 3,1416 * radius * radius;
            return radius;
        }






    }
}
