using FizzBuzz;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzTests
    {
        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(5)]
        public void WhenNotAMultipleOf3_ReturnEmptString(int numberUnderTest)
        {
            var fizz = new Fizz();
            var replacement = fizz.GetReplacement(numberUnderTest);
            replacement.Should().Be("");
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void WhenAMultipleOf3_ReturnFizz(int numberUnderTest)
        {
            var fizz = new Fizz();
            var replacement = fizz.GetReplacement(numberUnderTest);
            replacement.Should().Be("Fizz");
        }

    }
}