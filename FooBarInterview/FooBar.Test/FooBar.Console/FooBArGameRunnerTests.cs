using FooBar.Application;
using FooBar.Console;
using FooBar.Infrastructure;
using Moq;
using NUnit.Framework;

namespace FooBar.Test.FooBar.Console
{
    [TestFixture]
    public class FooBarGameRunnerTests
    {
        private FooBarGameRunner _fooBarGameRunner;
        private Mock<FooBarCalculator> _mockCalculator;
        private Mock<IFooBarLogger> _mockLogger;

        [SetUp]
        public void SetUp()
        {
            _mockCalculator = new Mock<FooBarCalculator>();
            _mockLogger = new Mock<IFooBarLogger>();
            _fooBarGameRunner = new FooBarGameRunner(_mockCalculator.Object, _mockLogger.Object);
        }

        [Test]
        public void ShouldParseInputArgumentsCorrectly()
        {
            string[] args = {"1", "100"};
            _fooBarGameRunner.Run(args);

            _mockCalculator.Verify(x=>x.Calculate(1,100), Times.Once);
        }

        [Test]
        public void ShouldReturnCorrectAnswerAtLimitsOfValidInputs()
        {
            _mockCalculator.Setup(x => x.Calculate(1, 100)).Returns("MyMockedString");

            string[] args = { "1", "100" };
            var result = _fooBarGameRunner.Run(args);

            Assert.AreEqual("MyMockedString", result);
        }

        [Test]
        public void ShouldValidateInputArgsAreIntegersAndReturnErrorString()
        {
            string[] args = { "foo", "10" };
            var result = _fooBarGameRunner.Run(args);

            Assert.AreEqual("'foo 10' Is not valid. Please enter two numbers between 0 and 100", result);
        }

        [Test]
        public void ShouldValidateCorrectNumberOfArgs()
        {
            string[] args = {  };
            var result = _fooBarGameRunner.Run(args);

            Assert.AreEqual("'' Is not valid. Please enter two numbers between 0 and 100", result);
        }

        [Test]
        public void ShouldValidateArgsAreNotOver100()
        {
            string[] args = {"1", "101"};
            var result = _fooBarGameRunner.Run(args);

            Assert.AreEqual("'1 101' Is not valid. Please enter two numbers between 0 and 100", result);
        }

        [Test]
        public void ShouldValidateArgsAreNotUnder1()
        {
            string[] args = { "0", "100" };
            var result = _fooBarGameRunner.Run(args);

            Assert.AreEqual("'0 100' Is not valid. Please enter two numbers between 0 and 100", result);
        }

        [Test]
        public void ShouldLogRequest()
        {
            string[] args = { "1", "100" };
            _fooBarGameRunner.Run(args);

            _mockLogger.Verify(x => x.Log(args), Times.Once);
        }
    }
}