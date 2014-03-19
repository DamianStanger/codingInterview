using System.Collections.Generic;
using System.Linq;

namespace shapes
{
    public class ShapeService
    {
        public double CombineAreaOf(IEnumerable<IShape> shapes)
        {
            return shapes.Sum(x => x.Area);
        }

        public double totalPerimeter(IEnumerable<IShape> shapes)
        {
            return shapes.Sum(x => x.Perimeter);
        }
    }
}