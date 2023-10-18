using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{

    [TestFixture]
    public class EvenOrOddTests
    {
        [TestCase(1)]
        [TestCase(7)]
        public void PositiveOddTest(int num)
        {
            Assert.That(EvenOrOdd.CalculateEvenOrOdd(num), Is.EqualTo("Odd"));
        }

        [TestCase(2)]
        [TestCase(42)]
        public void PositiveEvenTest(int num)
        {
            Assert.That(EvenOrOdd.CalculateEvenOrOdd(num), Is.EqualTo("Even"));
        }

        [TestCase(-1)]
        [TestCase(-7)]
        public void NegativeOddTest(int num)
        {
            Assert.That(EvenOrOdd.CalculateEvenOrOdd(num), Is.EqualTo("Odd"));
        }

        [TestCase(-2)]
        [TestCase(-42)]
        public void NegativeEvenTest(int num)
        {
            Assert.That(EvenOrOdd.CalculateEvenOrOdd(num), Is.EqualTo("Even"));
        }

        [Test]
        public void ZeroIsEvenTest()
        {
            Assert.That(EvenOrOdd.CalculateEvenOrOdd(0), Is.EqualTo("Even"));
        }
    }
}
