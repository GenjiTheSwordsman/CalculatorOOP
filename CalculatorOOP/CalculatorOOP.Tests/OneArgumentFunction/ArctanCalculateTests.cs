﻿using NUnit.Framework;

namespace CalculatorOOP.Tests
{
    [TestFixture]
    class ArctanCalculateTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.79)]
        [TestCase(-0.5, -0.46)]
        public void CalculateTest(double ArOne, double expected)
        {
            var calculator = new ArctanCalculate();
            var actualResult = calculator.Calculte(ArOne);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
