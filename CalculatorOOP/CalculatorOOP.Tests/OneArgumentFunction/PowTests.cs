using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class PowTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Pow();
            var actualResult = calculator.Calculte(4);
            Assert.AreEqual(16, actualResult);
        }
    }
}
