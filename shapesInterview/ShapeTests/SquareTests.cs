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
            double width = 3;
            IShape square = new Square(width);

            var actualArea = square.Area;

            var expectedArea = 9;
            actualArea.Should().Be(expectedArea);
        }

        [Test, Ignore]
        public void CanCalculateTotalArea()
        {
            IList<IShape> shapes = new List<IShape>();
//            shapes.Add(new Square(1));
//            shapes.Add(new Square(2));
//            shapes.Add(new Square(3));


            var combinedArea = 0d;


            combinedArea.Should().Be(14);
        }
    }
}
