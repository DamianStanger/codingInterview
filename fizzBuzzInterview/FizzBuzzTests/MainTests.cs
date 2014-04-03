using ConsoleApp;
using FizzBuzz;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class MainTests
    {
        [Test]
        public void WhenRun_CallsFizzAndBuzzOnce()
        {
            MockTester fizz = new MockTester();
            MockTester buzz = new MockTester();

            Program.Fizz = fizz;
            Program.Buzz = buzz;

            var args = new[] { "1" };
            Program.Main(args);

            fizz.called.Should().Be(1);
            buzz.called.Should().Be(1);
        }
    }


    public class MockTester : INumberTester
    {
        public int called = 0;

        public string GetReplacement(int number)
        {
            called += 1;
            return "";
        }
    }
}