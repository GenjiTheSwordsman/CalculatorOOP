﻿using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class LogarithmCalculateTests
    {
        [TestCase(10, 3.322)]
        [TestCase(1, 0)]
        [TestCase(5, 2.322)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new LogarithmCalculate();
            var actualResult = calculator.OneArgCalculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
