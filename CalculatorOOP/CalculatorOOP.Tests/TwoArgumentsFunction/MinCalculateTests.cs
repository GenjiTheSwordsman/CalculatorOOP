using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class MinCalculateTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(5, 2, 2)]
        [TestCase(-7, -5, -7)]
        public void CalculateTest(double arOne, double arTwo, double expected)
        {
            var calculator = new MinCalculate();
            var actualResult = calculator.TwoArgCalculate(arOne, arTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
