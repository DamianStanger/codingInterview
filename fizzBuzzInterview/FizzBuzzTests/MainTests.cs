using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

            Program.NumberTesters = new List<INumberTester>() { fizz, buzz };

            var args = new[] { "1" };
            Program.Main(args);

            fizz.called.Should().Be(1);
            buzz.called.Should().Be(1);
        }

        [Test]
        public void WhenRunPassing10_CallsFizzAndBuzz10Times()
        {
            MockTester fizz = new MockTester();
            MockTester buzz = new MockTester();

            Program.NumberTesters = new List<INumberTester>() { fizz, buzz };

            var args = new[] { "10" };
            Program.Main(args);

            fizz.called.Should().Be(10);
            buzz.called.Should().Be(10);
        }

        [Test]
        public void WhenRunPassing1_Writes1ToConsole()
        {
            MockTester fizz = new MockTester("");
            MockTester buzz = new MockTester("");

            Program.NumberTesters = new List<INumberTester>() { fizz, buzz };

            StringBuilder mockConsole = new StringBuilder();
            StringWriter stringWriter = new StringWriter(mockConsole);
            Console.SetOut(stringWriter);

            var args = new[] { "1" };
            Program.Main(args);

            mockConsole.ToString().Should().Be("1\r\n");
        }

        [Test]
        public void WhenRunPassingFizzBuzz_WritesFizzBuzzToConsole()
        {
            MockTester fizz = new MockTester("Fizz");
            MockTester buzz = new MockTester("Buzz");

            Program.NumberTesters = new List<INumberTester>() { fizz, buzz };

            StringBuilder mockConsole = new StringBuilder();
            StringWriter stringWriter = new StringWriter(mockConsole);
            Console.SetOut(stringWriter);

            var args = new[] { "1" };
            Program.Main(args);

            mockConsole.ToString().Should().Be("Fizz Buzz\r\n");
        }

        [Test]
        public void WhenRunPassingFizz_WritesFizzToConsole()
        {
            MockTester fizz = new MockTester("Fizz");
            MockTester buzz = new MockTester("");

            Program.NumberTesters = new List<INumberTester>() { fizz, buzz };

            StringBuilder mockConsole = new StringBuilder();
            StringWriter stringWriter = new StringWriter(mockConsole);
            Console.SetOut(stringWriter);

            var args = new[] { "1" };
            Program.Main(args);

            mockConsole.ToString().Should().Be("Fizz\r\n");
        }

    }


    public class MockTester : INumberTester
    {
        private readonly string _returnval;
        public int called = 0;

        public MockTester(string returnval = "")
        {
            _returnval = returnval;
        }

        public string GetReplacement(int number)
        {
            called += 1;
            return _returnval;
        }
    }
}