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
            IShape square = new Square(3);
            square.Area.Should().Be(9);
        }

        [Test, Ignore]
        public void CanCalculateTotalArea()
        {
            IList<IShape> shapes = new List<IShape>();
//            shapes.Add(new Square(1));
//            shapes.Add(new Square(2));
//            shapes.Add(new Square(3));


            var combinedArea = 0d;


            combinedArea.Should().Be(15);
        }
    }
}
