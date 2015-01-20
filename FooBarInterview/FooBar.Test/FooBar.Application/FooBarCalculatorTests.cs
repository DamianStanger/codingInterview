using FooBar.Application;
using NUnit.Framework;

namespace FooBar.Test.FooBar.Application
{
    [TestFixture]
    public class FooBarCalculatorTests
    {
        [Test]
        public void ShouldStartOneTwo()
        {
            var result = new FooBarCalculator().Calculate(1,2);

            Assert.AreEqual("1 2", result);
        }

        [Test]
        public void ShouldSubstituteFooForThree()
        {
            var result = new FooBarCalculator().Calculate(3,3);

            Assert.AreEqual("Foo", result);
        }

        [Test]
        public void ShouldSubstituteBarForFive()
        {
            var result = new FooBarCalculator().Calculate(5,5);

            Assert.AreEqual("Bar", result);
        }

        [Test]
        public void ShouldSubstituteFooBarForFifteen()
        {
            var result = new FooBarCalculator().Calculate(15, 15);

            Assert.AreEqual("FooBar", result);
        }

        [Test]
        public void ShouldSubstituteForMultiplesOfThreeAndFiveAndFifteen()
        {
            var result = new FooBarCalculator().Calculate(1,30);

            Assert.AreEqual("1 2 Foo 4 Bar Foo 7 8 Foo Bar 11 Foo 13 14 FooBar 16 17 Foo 19 Bar Foo 22 23 Foo Bar 26 Foo 28 29 FooBar", result);
        }

     
    }
}