using Polygons.Library;
using System;
/*
 * Zahra Bodaghi
 */

namespace Polygons
{
    public class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("Square", square);

            var triangle = new Triangle(length: 5);
            DisplayPolygon(polygonType: "Triangle", polygon: triangle);

            var octagon = new Octagon(length: 5);
            DisplayPolygon(polygonType: "Octagon", polygon: octagon);

            var pentagon = new Pentagon(length: 5);
            DisplayPolygon(polygonType: "Pentagon", polygon: pentagon);

            Console.WriteLine();
            Console.WriteLine("Zahra Bodaghi"); 
            Console.WriteLine("Assignment Week 2");
            Console.WriteLine();
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }

        public static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine($"{polygonType} Number of Sides: {polygon.NumberOfSides}");
                Console.WriteLine("{0} Side Length: {1}", polygonType, polygon.SideLength);
                Console.WriteLine("{0} Perimeter: {1}", polygonType, polygon.GetPerimeter());
                Console.WriteLine("{0} Area: {1}", polygonType, Math.Round(polygon.GetArea(), 2));
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown while trying to process {0}:\n   {1}",
                    polygonType, ex.GetType().Name);
                Console.WriteLine();
            }
        }
    }
}