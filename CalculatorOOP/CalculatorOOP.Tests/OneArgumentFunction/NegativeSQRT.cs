using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class NegativeSQRT
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new SQRT();
            var actualResult = calculator.Calculte(4);
            Assert.AreEqual(2, actualResult);
        }
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new SQRT();
            Assert.Throws<System.Exception>(() => calculator.Calculte(-4));
        }

    }
}
