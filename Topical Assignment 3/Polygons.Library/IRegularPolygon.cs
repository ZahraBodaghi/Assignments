using System;

/*
 * Zahra Bodaghi
 */

namespace Polygons.Library
{
    public interface IRegularPolygon
    {
        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        double Perimeter();
        double GetArea();
    }
}
