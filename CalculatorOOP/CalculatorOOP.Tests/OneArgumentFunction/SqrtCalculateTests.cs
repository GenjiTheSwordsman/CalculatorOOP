using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class SqrtCalculateTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new SqrtCalculate();
            var actualResult = calculator.OneArgCalculate(4);
            Assert.AreEqual(2, actualResult);
        }
    }
}
