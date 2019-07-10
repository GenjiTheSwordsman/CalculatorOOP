using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class AdditionCalculatorTests
    {
        [Test]
        public void CalculateTest() {
            var calculator = new AdditionCalculator();
            var actualReuslt = calculator.Calculate(3, 4);
            Assert.AreEqual(7, actualReuslt);
        }
    }
}
