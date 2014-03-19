using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using shapes;

namespace ShapeTests
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void AreaShouldReturnWidthSquared()
        {
            const double width = 3;
            IShape square = new Square(width);
            square.Area.Should().Be(9);
        }

        [Test]
        public void CanCalculateTotalArea()
        {
            IList<IShape> shapes = new List<IShape>();
            shapes.Add(new Square(1));
            shapes.Add(new Square(2));
            shapes.Add(new Square(3));


            var shapeProcessor = new ShapeService();
            double combinedArea = shapeProcessor.CombineAreaOf(shapes);


            combinedArea.Should().Be(14);
        }
    }
}
