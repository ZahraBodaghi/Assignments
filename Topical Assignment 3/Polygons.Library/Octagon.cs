using System;
using System.Collections.Generic;
using System.Text;
/*
 * Zahra Bodaghi
 */
namespace Polygons.Library
{
    public class Octagon : IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }
        public Octagon(int length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }
        public double Perimeter() => NumberOfSides * SideLength;
        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}
