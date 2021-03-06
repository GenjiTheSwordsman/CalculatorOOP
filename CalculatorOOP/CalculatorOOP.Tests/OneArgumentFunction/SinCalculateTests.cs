﻿using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class SinCalculateTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.84)]
        [TestCase(-2, -0.91)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new SinCalculate();
            var actualResult = calculator.OneArgCalculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
