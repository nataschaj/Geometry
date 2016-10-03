using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class Geometry
    {
        // Note that this class does not need any instance fields
        // (why...?)

        // Constructor
        public Geometry()
        {
        }

        // Calculate perimeter of a rectangle
        public double CalculateRectanglePerimeter(double sideA, double sideB)
        {
            double perimeter = 2 * sideA + 2 * sideB;
            return perimeter;
        }

        // Calculate area of a rectangle
        public double CalculateRectangleArea(double sideA, double sideB)
        {
            double area = sideA * sideB;
            return area;
        }

        // Calculate area of a circle
        public double CalculateCircleArea(double radius)
        {
            // PI is assumed to be 3.1416
            double area = 3.1416 * radius * radius;
            return area;
        }

        // Check if the given polygon is a rectangle (i.e. if all angles are 90 degrees)
        public bool IsPolygonARectangle(int angleA, int angleB, int angleC, int angleD)
        {
            bool isRectangle = (angleA == 90) && (angleB == 90) && (angleC == 90) && (angleD == 90);
            return isRectangle;
        }

        // Given two angles of a triangle, calculate the last angle
        // Use the fact that the sum of the angles in a triangle is 180
        public int CalculateThirdAngleOfTriangle(int angleA, int angleB)
        {
            int angleC = 180 - angleA - angleB;
            return angleC;
        }
    }
}
