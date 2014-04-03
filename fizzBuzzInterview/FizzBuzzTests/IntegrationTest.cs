using System;
using System.IO;
using System.Text;
using FizzBuzz;
using FluentAssertions;
using NUnit.Framework;
using ConsoleApp;

namespace FizzBuzzTests
{
    [TestFixture]
    public class IntegrationTest
    {
        const string OneToThirty = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizz Buzz\n16\n17\nFizz\n19\nBuzz\nFizz\n22\n23\nFizz\nBuzz\n26\nFizz\n28\n29\nFizz Buzz";
        private const string OneToTwo = "1\r\n2\r\n";

        [Test]
        public void ShouldProduceFullFizzBuzzOutput()
        {
            var args = new[] {"30"};
            var sb = new StringBuilder();
            Console.SetOut(new StringWriter(sb));
            
            Program.Fizz = new Fizz();
            Program.Buzz = new Buzz();

            Program.Main(args);
            string actual = sb.ToString();

            actual.Should().Be(OneToThirty);
        }

        [Test]
        public void ShouldProduceShortFizzBuzzOutput()
        {
            var args = new[] { "2" };
            var sb = new StringBuilder();
            Console.SetOut(new StringWriter(sb));

            Program.Fizz = new Fizz();
            Program.Buzz = new Buzz();

            Program.Main(args);
            string actual = sb.ToString();

            actual.Should().Be(OneToTwo);
        }

    }
}