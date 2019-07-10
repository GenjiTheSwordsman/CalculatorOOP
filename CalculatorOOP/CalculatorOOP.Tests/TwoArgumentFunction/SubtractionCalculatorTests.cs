using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class SubtractionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new SubtractionCalculator();
            var actualReuslt = calculator.Calculate(15, 5);
            Assert.AreEqual(3.0, actualReuslt);
        }
    }
}
