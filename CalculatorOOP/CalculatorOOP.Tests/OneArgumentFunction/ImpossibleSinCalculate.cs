using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ImpossibleSinCalculate
    {
        
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new SinCalculate();
            Assert.Throws<System.Exception>(() => calculator.Calculte(-4));
        }

    }
}
