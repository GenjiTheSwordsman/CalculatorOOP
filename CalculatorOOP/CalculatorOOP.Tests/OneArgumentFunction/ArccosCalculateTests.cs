using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ArccosCalculateTests
    {
        [TestCase(0, 1.57)]
        [TestCase(1, 0)]
        [TestCase(-0.5, 2.09)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new ArccosCalculate();
            var actualResult = calculator.OneArgCalculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
