using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ModuleNumberCalculateTests
    {
        [TestCase(0, 0)]
        [TestCase(-1, 1)]
        [TestCase(4, 4)]
        public void CalculateTest(double ArOne, double expected)
        {
            var calculator = new ModuleNumberCalculate();
            var actualResult = calculator.Calculte(ArOne);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
