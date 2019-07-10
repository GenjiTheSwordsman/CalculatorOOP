using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class OneDivArgCalculateTests
    {
        [TestCase(2, 0.5)]
        [TestCase(-0.5, -2)]
        [TestCase(1, 1)]
        public void CalculateTest(double ArOne, double expected)
        {
            var calculator = new OneDivArgCalculate();
            var actualResult = calculator.Calculte(ArOne);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
