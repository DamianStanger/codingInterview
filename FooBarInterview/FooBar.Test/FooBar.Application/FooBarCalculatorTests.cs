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
            var result = new FooBarCalculator().Calculate();

            Assert.AreEqual("1 2", result.Substring(0, 3));
        }

        [Test]
        public void ShouldSubstituteFooForThree()
        {
            var result = new FooBarCalculator().Calculate();

            Assert.AreEqual("1 2 Foo 4", result.Substring(0,9));
        }

        [Test]
        public void ShouldSubstituteFooForMultiplesOfThree()
        {
            var result = new FooBarCalculator().Calculate();

            Assert.AreEqual("1 2 Foo 4 5 Foo 7 8 Foo 10", result);
        }
    }
}