using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ImpossibleArcTanCalculate
    {
       
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new ArctanCalculate();
            Assert.Throws<System.Exception>(() => calculator.Calculte(-4));
        }

    }
}
