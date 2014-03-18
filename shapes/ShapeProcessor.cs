using System.Collections.Generic;
using System.Linq;

namespace shapes
{
    public class ShapeProcessor
    {
        public double CombineAreaOf(IEnumerable<IShape> shapes)
        {
            return shapes.Sum(x => x.Area);
        }
    }
}