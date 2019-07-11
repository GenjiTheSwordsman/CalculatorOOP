using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class CtanCalculateTests
    {
        [TestCase(3, -7.02)]
        [TestCase(1, 0.64)]
        [TestCase(-2, 0.46)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new CtanCalculate();
            var actualResult = calculator.OneArgCalculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
