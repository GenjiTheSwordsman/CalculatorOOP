using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class TwoPowerNumberCalculateTests
    {
        [TestCase(4, 16)]
        [TestCase(1, 2)]
        [TestCase(0, 1)]
        public void CalculateTest(double ArOne, double expected)
        {
            var calculator = new TwoPowerNumberCalculate();
            var actualResult = calculator.Calculte(ArOne);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
