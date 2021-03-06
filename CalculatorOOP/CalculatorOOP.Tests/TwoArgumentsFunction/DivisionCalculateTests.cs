﻿using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class DivisionCalculateTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new DivisionCalculate();
            var actualResult = calculator.TwoArgCalculate(15, 5);
            Assert.AreEqual(3.0, actualResult);
        }
    }
}
