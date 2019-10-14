using System;
using System.Collections.Generic;
using System.Text;
/*
 * Zahra Bodaghi
 */
namespace Polygons.Library
{
    public class Pentagon : AbstractRegularPolygon
    {
        public Pentagon(int length) : base (5, length) { }
        public override double GetArea()
        {
            return (1.72) * SideLength * SideLength;
        }
    }
}
