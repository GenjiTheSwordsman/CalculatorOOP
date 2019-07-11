using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ImpossibleLogarithmToTheBaseTenCalculateTests
    {
        
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new LogarithmToTheBaseTenCalculate();
            Assert.Throws<System.Exception>(() => calculator.OneArgCalculate(-4));
        }

    }
}
