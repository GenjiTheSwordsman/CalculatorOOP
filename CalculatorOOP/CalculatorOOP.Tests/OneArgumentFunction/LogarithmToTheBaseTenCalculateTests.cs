﻿using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class LogarithmToTheBaseTenCalculateTests
    {
        [TestCase(10, 1)]
        [TestCase(5, 0.69)]
        [TestCase(1, 0)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new LogarithmToTheBaseTenCalculate();
            var actualResult = calculator.OneArgCalculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}

