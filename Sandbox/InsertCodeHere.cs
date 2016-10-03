using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Create a Geometry object
            Geometry geo = new Geometry();

            // Test it!
            //
            Console.WriteLine("Test using rectangle with side lengths 8 and 14...");
            Console.WriteLine("Perimeter is {0}", geo.CalculateRectanglePerimeter(8, 14));
            Console.WriteLine("Area is {0}", geo.CalculateRectangleArea(8, 14));

            Console.WriteLine("Test using rectangle with side lengths 2 and 21...");
            Console.WriteLine("Perimeter is {0}", geo.CalculateRectanglePerimeter(2, 21));
            Console.WriteLine("Area is {0}", geo.CalculateRectangleArea(2, 21));

            Console.WriteLine("Test using circle with radius 7...");
            Console.WriteLine("Area is {0}", geo.CalculateCircleArea(7));

            Console.WriteLine("Test using circle with radius 30...");
            Console.WriteLine("Area is {0}", geo.CalculateCircleArea(30));

            Console.WriteLine("Test using polygon with angles 90, 90, 100 and 80");
            Console.WriteLine("Polygon is a rectangle : {0}", geo.IsPolygonARectangle(90, 90, 100, 80));

            Console.WriteLine("Test using polygon with angles 90, 90, 90 and 90");
            Console.WriteLine("Polygon is a rectangle : {0}", geo.IsPolygonARectangle(90, 90, 90, 90));

            Console.WriteLine("Test using triangle with angles 20 and 80");
            Console.WriteLine("Last angle is {0}", geo.CalculateThirdAngleOfTriangle(20, 80));

            Console.WriteLine("Test using triangle with angles 50 and 105");
            Console.WriteLine("Last angle is {0}", geo.CalculateThirdAngleOfTriangle(50, 105));

            // The LAST line of code should be ABOVE this line
        }
    }
}
