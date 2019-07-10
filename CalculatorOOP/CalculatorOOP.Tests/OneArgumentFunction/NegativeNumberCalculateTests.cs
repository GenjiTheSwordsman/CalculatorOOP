using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class NegativeNumberCalculateTests
    {
        [TestCase(3, -3)]
        [TestCase(-2, 2)]
        [TestCase(0.5, -0.5)]
        public void CalculateTest(double ArOne, double expected)
        {
            var calculator = new NegativeNumberCalculate();
            var actualResult = calculator.Calculte(ArOne);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
