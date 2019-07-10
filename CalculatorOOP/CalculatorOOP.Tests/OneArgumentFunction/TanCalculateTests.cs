using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class TanCalculateTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.56)]
        [TestCase(-2, 2.19)]
        public void CalculateTest(double ArOne, double expected)
        {
            var calculator = new TanCalculate();
            var actualResult = calculator.Calculte(ArOne);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
