using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ImpossibleLogarithmToTheBaseTenCalculate
    {
        
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new LogarithmToTheBaseTenCalculate();
            Assert.Throws<System.Exception>(() => calculator.Calculte(-4));
        }

    }
}
