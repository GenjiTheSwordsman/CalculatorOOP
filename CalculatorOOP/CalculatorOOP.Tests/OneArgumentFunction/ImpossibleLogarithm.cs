using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ImpossibleLogarithm
    {
        
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new LogarithmCalculate();
            Assert.Throws<System.Exception>(() => calculator.Calculte(-4));
        }

    }
}
