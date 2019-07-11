using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class CosCalculateTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 0.54)]
        [TestCase(-2, -0.42)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new CosCalculate();
            var actualResult = calculator.OneArgCalculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
