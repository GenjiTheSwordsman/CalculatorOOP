using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ImpossibleNaturalLogarithmCalculateTests
    {
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new NaturalLogarithmCalculate();
            Assert.Throws<System.Exception>(() => calculator.OneArgCalculate(-4));
        }

    }
}
