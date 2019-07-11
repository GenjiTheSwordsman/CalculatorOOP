using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class TwoPowerNumberCalculateTests
    {
        [TestCase(4, 16)]
        [TestCase(1, 2)]
        [TestCase(0, 1)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new TwoPowerNumberCalculate();
            var actualResult = calculator.OneArgCalculate(arOne);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
