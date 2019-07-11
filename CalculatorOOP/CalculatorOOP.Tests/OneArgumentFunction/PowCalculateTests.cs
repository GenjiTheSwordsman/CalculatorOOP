using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class PowCalculateTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new PowCalculate();
            var actualResult = calculator.OneArgCalculate(4);
            Assert.AreEqual(16, actualResult);
        }
    }
}
