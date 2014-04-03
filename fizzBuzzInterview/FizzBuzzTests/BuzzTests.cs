using FizzBuzz;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class BuzzTests
    {
        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(6)]
        public void WhenNotAMultipleOf5_ReturnEmptString(int numberUnderTest)
        {
            var buzz = new Buzz();
            var replacement = buzz.GetReplacement(numberUnderTest);
            replacement.Should().Be("");
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(15)]
        public void WhenAMultipleOf5_ReturnBuzz(int numberUnderTest)
        {
            var buzz = new Buzz();
            var replacement = buzz.GetReplacement(numberUnderTest);
            replacement.Should().Be("Buzz");
        }

    }
}