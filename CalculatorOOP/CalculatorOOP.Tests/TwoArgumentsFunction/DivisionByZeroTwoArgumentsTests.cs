using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class DivisionByZeroTwoArguments
    {
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new DivisionCalculate();
            Assert.Throws<System.Exception>(() => calculator.TwoArgCalculate(1,0));
        }

    }
}
