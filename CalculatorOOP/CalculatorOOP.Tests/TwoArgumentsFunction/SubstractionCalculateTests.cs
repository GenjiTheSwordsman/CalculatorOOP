using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class SubstractionCalculateTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new SubstractionCalculate();
            var actualResult = calculator.TwoArgCalculate(5, 4);
            Assert.AreEqual(1, actualResult);
        }
    }
}
