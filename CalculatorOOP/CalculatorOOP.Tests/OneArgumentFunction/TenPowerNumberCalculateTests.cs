using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class TenPowerNumberCalculateTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 10)]
        [TestCase(-1, 0.1)]
        public void CalculateTest(double ArOne, double expected)
        {
            var calculator = new TenPowerNumberCalculate();
            var actualResult = calculator.Calculte(ArOne);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
