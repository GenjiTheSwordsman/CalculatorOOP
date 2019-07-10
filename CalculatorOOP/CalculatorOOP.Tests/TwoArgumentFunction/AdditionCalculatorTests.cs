using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class AdditionCalculatorTests
    {
        public void CalculateTest() {
            var calculator = new AdditionCalculator();
            var actualResult = calculator.Calculate(3, 4);
            Assert.AreEqual(7, actualResult);
        }
    }
}
