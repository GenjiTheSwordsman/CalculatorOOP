using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ArcsinCalculateTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.57)]
        [TestCase(-0.5, -0.53)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new ArcsinCalculate();
            var actualResult = calculator.OneArgCalculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
