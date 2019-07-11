using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class DivisionByZero
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new OneDivArgCalculate();
            var actualResult = calculator.Calculte(1);
            Assert.AreEqual(1, actualResult);
        }
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new OneDivArgCalculate();
            Assert.Throws<System.Exception>(() => calculator.Calculte(0));
        }

    }
}
