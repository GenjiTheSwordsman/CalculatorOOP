using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class SQRTtests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new SQRT();
            var actualResult = calculator.Calculte(4);
            Assert.AreEqual(2, actualResult);
        }
    }
}
