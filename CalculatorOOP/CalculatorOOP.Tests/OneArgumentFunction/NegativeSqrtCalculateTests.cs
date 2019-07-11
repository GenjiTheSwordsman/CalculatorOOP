using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class NegativeSqrtCalculateTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new SqrtCalculate();
            var actualResult = calculator.OneArgCalculate(4);
            Assert.AreEqual(2, actualResult);
        }
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new SqrtCalculate();
            Assert.Throws<System.Exception>(() => calculator.OneArgCalculate(-4));
        }

    }
}
