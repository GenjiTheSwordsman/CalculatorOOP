using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class MiddleArithmeticTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(10, -4, 3)]
        [TestCase(4, 5, 4.5)]
        public void CalculateTest(double ArOne, double ArTwo, double expected)
        {
            var calculator = new MiddleArithmeticCalculate();
            var actualResult = calculator.Calculate(ArOne, ArTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
