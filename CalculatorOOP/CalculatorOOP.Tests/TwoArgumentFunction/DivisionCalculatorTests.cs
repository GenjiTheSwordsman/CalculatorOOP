using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class DivisionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new DivisionCalculator();
            var actualResult = calculator.Calculate(5, 4);
            Assert.AreEqual(1, actualResult);
        }
    }
}
