
using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class NaturalLogarithmCalculateTests
    {
        [TestCase(10, 2.3)]
        [TestCase(5, 1.6)]
        [TestCase(1, 0)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new NaturalLogarithmCalculate();
            var actualResult = calculator.OneArgCalculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
