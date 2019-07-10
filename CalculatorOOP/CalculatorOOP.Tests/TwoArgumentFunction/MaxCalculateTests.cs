using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class MaxCalculateTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(5, 2, 5)]
        [TestCase(-7, -5, -5)]
        public void CalculateTest(double ArOne, double ArTwo, double expected)
        {
            var calculator = new MaxCalculate();
            var actualResult = calculator.Calculate(ArOne, ArTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
