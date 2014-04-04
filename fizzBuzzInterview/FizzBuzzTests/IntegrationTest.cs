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
        private const string OneToThirty = "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizz Buzz\r\n16\r\n17\r\nFizz\r\n19\r\nBuzz\r\nFizz\r\n22\r\n23\r\nFizz\r\nBuzz\r\n26\r\nFizz\r\n28\r\n29\r\nFizz Buzz\r\n";
        private const string OneToTwo = "1\r\n2\r\n";

        [Test]
        public void ShouldProduceShortFizzBuzzOutput()
        {
            var args = new[] { "2" };
            var sb = new StringBuilder();
            Console.SetOut(new StringWriter(sb));

            Program.Main(args);
            string actual = sb.ToString();

            actual.Should().Be(OneToTwo);
        }

        [Test]
        public void ShouldProduceFullFizzBuzzOutput()
        {
            var args = new[] {"30"};
            var sb = new StringBuilder();
            Console.SetOut(new StringWriter(sb));

            Program.Main(args);
            string actual = sb.ToString();

            actual.Should().Be(OneToThirty);
        }        
    }
}