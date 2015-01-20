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

            string[] args = {"1", "100"};
            new FooBarGameRunner(mockCalculator.Object).Run(args);

            mockCalculator.Verify(x=>x.Calculate(1,100), Times.Once);
        }

        [Test]
        public void ShouldReturnCorrectAnswerAtLimitsOfValidInputs()
        {
            var mockCalculator = new Mock<FooBarCalculator>();
            mockCalculator.Setup(x => x.Calculate(1, 100)).Returns("MyMockedString");

            string[] args = { "1", "100" };
            var result = new FooBarGameRunner(mockCalculator.Object).Run(args);

            Assert.AreEqual("MyMockedString", result);
        }

        [Test]
        public void ShouldValidateInputArgsAreIntegersAndReturnErrorString()
        {
            var mockCalculator = new Mock<FooBarCalculator>();

            string[] args = { "foo", "10" };
            var result = new FooBarGameRunner(mockCalculator.Object).Run(args);

            Assert.AreEqual("'foo 10' Is not valid. Please enter two numbers between 0 and 100", result);
        }

        [Test]
        public void ShouldValidateCorrectNumberOfArgs()
        {
            var mockCalculator = new Mock<FooBarCalculator>();

            string[] args = {  };
            var result = new FooBarGameRunner(mockCalculator.Object).Run(args);

            Assert.AreEqual("'' Is not valid. Please enter two numbers between 0 and 100", result);
        }

        [Test]
        public void ShouldValidateArgsAreNotOver100()
        {
            var mockCalculator = new Mock<FooBarCalculator>();

            string[] args = {"1", "101"};
            var result = new FooBarGameRunner(mockCalculator.Object).Run(args);

            Assert.AreEqual("'1 101' Is not valid. Please enter two numbers between 0 and 100", result);
        }

        [Test]
        public void ShouldValidateArgsAreNotUnder1()
        {
            var mockCalculator = new Mock<FooBarCalculator>();

            string[] args = { "0", "100" };
            var result = new FooBarGameRunner(mockCalculator.Object).Run(args);

            Assert.AreEqual("'0 100' Is not valid. Please enter two numbers between 0 and 100", result);
        }
    }
}