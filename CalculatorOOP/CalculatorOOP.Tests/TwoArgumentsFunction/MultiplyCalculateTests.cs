using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class MultiplyCalculateTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new MultiplyCalculate();
            var actualResult = calculator.TwoArgCalculate(7, 2);
            Assert.AreEqual(14, actualResult);
        }
    }
}
