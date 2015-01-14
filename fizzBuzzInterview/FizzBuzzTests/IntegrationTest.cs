using System;
using System.IO;
using System.Text;
using FluentAssertions;
using NUnit.Framework;
using ConsoleApp;

namespace FizzBuzzTests
{
    [TestFixture]
    public class IntegrationTest
    {
        private StringBuilder _sb;
        private const string ExpectedTwo = "1 2";
        private const string ExpectedThree = "1 2 Fizz";
        private const string ExpectedFive = "1 2 Fizz 4 Buzz";
        private const string ExpectedThirty = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz";

        [SetUp]
        public void Setup()
        {
            _sb = new StringBuilder();
            Console.SetOut(new StringWriter(_sb));
        }

        [Test]
        public void ShouldProduceNumeric_FizzBuzzOutput()
        {
            var args = new[] { "2" };

            Program.Main(args);

            string actual = _sb.ToString();
            actual.Should().Be(ExpectedTwo);
        }

        [Test]
        public void ShouldProduceFizz_FizzBuzzOutput()
        {
            var args = new[] { "3" };

            Program.Main(args);

            string actual = _sb.ToString();
            actual.Should().Be(ExpectedThree);
        }

        [Test]
        public void ShouldProduceBuzz_FizzBuzzOutput()
        {
            var args = new[] { "5" };

            Program.Main(args);
            
            string actual = _sb.ToString();
            actual.Should().Be(ExpectedFive);
        }

        [Test, Ignore]
        public void ShouldProduceFull_FizzBuzzOutput()
        {
            var args = new[] {"30"};

            Program.Main(args);

            string actual = _sb.ToString();
            actual.Should().Be(ExpectedThirty);
        }        
    }
}