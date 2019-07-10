using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class MultiplyCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new MultiplyCalculator();
            var actualResult = calculator.Calculate(7, 2);
            Assert.AreEqual(14, actualResult);
        }
    }
}
