using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ImpossibleNaturalLogarithm
    {
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new NaturalLogarithmCalculate();
            Assert.Throws<System.Exception>(() => calculator.Calculte(-4));
        }

    }
}
