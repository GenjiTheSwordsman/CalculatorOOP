using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class DivisionByZeroTwoArguments
    {
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new SubtractionCalculator();
            Assert.Throws<System.Exception>(() => calculator.Calculate(1,0));
        }

    }
}
