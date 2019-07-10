using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class DivisinonCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new DivisionCalculator();
            var actualReuslt = calculator.Calculate(5, 4);
            Assert.AreEqual(1, actualReuslt);
        }
    }
}
