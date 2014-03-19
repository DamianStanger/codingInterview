using System.Collections.Generic;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using shapes;

namespace ShapeTests
{
    [TestFixture]
    public class ShapeServiceTests
    {
        [Test]
        public void CalculateTotalPerimeterShouldReturnTotal()
        {
            const int shapeOnePerimeter = 4;
            const int shapeTwoPerimeter = 8;
            const int shapeThreePerimeter = 12;

            IList<IShape> shapes = new List<IShape>();
            //add shapes
            var shape1 = new Mock<IShape>();
            var shape2 = new Mock<IShape>();
            var shape3 = new Mock<IShape>();
            shape1.Setup(x => x.Perimeter).Returns(shapeOnePerimeter);
            shape2.Setup(x => x.Perimeter).Returns(shapeTwoPerimeter);
            shape3.Setup(x => x.Perimeter).Returns(shapeThreePerimeter);
            shapes.Add(shape1.Object);
            shapes.Add(shape2.Object);
            shapes.Add(shape3.Object);

            //call method 
            var service = new ShapeService();
            double totalParimeter = service.totalPerimeter(shapes);

            //assert result
            totalParimeter.Should().Be(shapeOnePerimeter + shapeTwoPerimeter + shapeThreePerimeter);
        }
    }
}