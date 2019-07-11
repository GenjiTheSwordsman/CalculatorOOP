using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class AdditionCalculateTests
    {
        [Test]
        public void CalculateTest() {
            var calculator = new AdditionCalculate();
            var actualResult = calculator.TwoArgCalculate(3, 4);
            Assert.AreEqual(7, actualResult);
        }
    }
}
