using FluentAssertions;
using NUnit.Framework;
using ConsoleApp;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzCalculatorTest
    {
        private const string ExpectedTwo = "1 2";
        private const string ExpectedThree = "1 2 Fizz";
        private const string ExpectedFive = "1 2 Fizz 4 Buzz";

        [Test]
        public void ShouldProduceNumeric_FizzBuzzOutput()
        {
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var actual = fizzBuzzCalculator.CalculateFizzBuzz(2);

            actual.Should().Be(ExpectedTwo);
        }

        [Test]
        public void ShouldProduceFizz_FizzBuzzOutput()
        {
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var actual = fizzBuzzCalculator.CalculateFizzBuzz(3);

            actual.Should().Be(ExpectedThree);
        }

        [Test]
        public void ShouldProduceBuzz_FizzBuzzOutput()
        {
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var actual = fizzBuzzCalculator.CalculateFizzBuzz(5);

            actual.Should().Be(ExpectedFive);
        }
     
    }
}