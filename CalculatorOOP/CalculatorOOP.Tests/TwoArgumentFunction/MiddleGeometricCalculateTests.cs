using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class MiddleGeometricCalculateTests
    {
        [TestCase(4, 4, 4)]
        [TestCase(-12, -12, 12)]
        [TestCase(6, 6, 6)]
        public void CalculateTest(double ArOne, double ArTwo, double expected)
        {
            var calculator = new MiddleGeometricCalculate();
            var actualResult = calculator.Calculate(ArOne, ArTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
