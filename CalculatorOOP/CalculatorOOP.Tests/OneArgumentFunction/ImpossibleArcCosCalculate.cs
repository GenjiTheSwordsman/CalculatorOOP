using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ImpossibleArcCosCalculate
    {
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new ArccosCalculate();
            Assert.Throws<System.Exception>(() => calculator.OneArgCalculate(-4));
        }
    }
}
