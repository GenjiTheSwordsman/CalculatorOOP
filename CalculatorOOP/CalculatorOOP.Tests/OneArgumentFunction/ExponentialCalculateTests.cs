using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]//уле=еле
    class ExponentialCalculateTests
    {
        [TestCase(1, 2.71)]
        [TestCase(0, 1)]
        [TestCase(2, 7.38)]
        public void CalculateTest(double ArOne, double expected)
        {
            var calculator = new ExponentialCalculate();
            var actualResult = calculator.Calculte(ArOne);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
