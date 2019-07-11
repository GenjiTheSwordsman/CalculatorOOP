using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class DivisionByZeroTwoArguments
    {
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new ArcsinCalculate();
            Assert.Throws<System.Exception>(() => calculator.Calculte(0));
        }

    }
}
