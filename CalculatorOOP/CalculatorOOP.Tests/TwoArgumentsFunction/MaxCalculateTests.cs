using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class MaxCalculateTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(5, 2, 5)]
        [TestCase(-7, -5, -5)]
        public void CalculateTest(double arOne, double arTwo, double expected)
        {
            var calculator = new MaxCalculate();
            var actualResult = calculator.TwoArgCalculate(arOne, arTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
