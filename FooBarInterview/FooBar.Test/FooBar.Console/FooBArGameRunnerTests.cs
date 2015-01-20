using FooBar.Application;
using FooBar.Console;
using Moq;
using NUnit.Framework;

namespace FooBar.Test.FooBar.Console
{
    [TestFixture]
    public class FooBarGameRunnerTests
    {
        [Test]
        public void ShouldParseInputArgumentsCorrectly()
        {
            var mockCalculator = new Mock<FooBarCalculator>();

            string[] args = {"1", "10"};
            new FooBarGameRunner(mockCalculator.Object).Run(args);

            mockCalculator.Verify(x=>x.Calculate(1,10), Times.Once);
        }
    }
}