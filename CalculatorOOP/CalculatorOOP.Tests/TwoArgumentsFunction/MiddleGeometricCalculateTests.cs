using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class MiddleGeometricCalculateTests
    {
        [TestCase(4, 4, 4)]
        [TestCase(-12, -12, 12)]
        [TestCase(6, 6, 6)]
        public void CalculateTest(double arOne, double arTwo, double expected)
        {
            var calculator = new MiddleGeometricCalculate();
            var actualResult = calculator.TwoArgCalculate(arOne, arTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
