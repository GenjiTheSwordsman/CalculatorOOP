using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class MiddleArithmeticCalculateTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(10, -4, 3)]
        [TestCase(4, 5, 4.5)]
        public void CalculateTest(double arOne, double arTwo, double expected)
        {
            var calculator = new MiddleArithmeticCalculate();
            var actualResult = calculator.TwoArgCalculate(arOne, arTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
