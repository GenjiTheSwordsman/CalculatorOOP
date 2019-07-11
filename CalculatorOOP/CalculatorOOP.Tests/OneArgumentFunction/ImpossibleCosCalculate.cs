using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ImpossibleCosCalculate
    {
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new CosCalculate();
            Assert.Throws<System.Exception>(() => calculator.Calculte(-4));
        }

    }
}
