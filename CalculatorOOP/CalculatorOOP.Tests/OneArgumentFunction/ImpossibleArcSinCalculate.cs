using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ImpossibleArcSinCalculate
    {
       
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new ArcsinCalculate();
            Assert.Throws<System.Exception>(() => calculator.Calculte(-4));
        }

    }
}
