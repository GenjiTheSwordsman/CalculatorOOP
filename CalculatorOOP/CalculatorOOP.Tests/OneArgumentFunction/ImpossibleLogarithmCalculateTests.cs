using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ImpossibleLogarithmCalculateTests
    {
        
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new LogarithmCalculate();
            Assert.Throws<System.Exception>(() => calculator.OneArgCalculate(-4));
        }

    }
}
