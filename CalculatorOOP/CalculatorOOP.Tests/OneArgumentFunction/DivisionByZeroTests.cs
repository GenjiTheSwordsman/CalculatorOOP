using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class DivisionByZeroTests
    {
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new OneDivArgCalculate();
            Assert.Throws<System.Exception>(() => calculator.OneArgCalculate(0));
        }

    }
}
