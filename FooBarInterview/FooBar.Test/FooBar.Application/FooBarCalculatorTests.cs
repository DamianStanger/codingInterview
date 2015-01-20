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
            var result = new FooBarCalculator().Calculate(1,4);

            Assert.AreEqual("1 2 Foo 4", result);
        }

        [Test]
        public void ShouldSubstituteBarForFive()
        {
            var result = new FooBarCalculator().Calculate(4,5);

            Assert.AreEqual("4 Bar", result);
        }

        [Test]
        public void ShouldSubstituteFooForMultiplesOfThreeAndFive()
        {
            var result = new FooBarCalculator().Calculate(1,10);

            Assert.AreEqual("1 2 Foo 4 Bar Foo 7 8 Foo Bar", result);
        }

     
    }
}