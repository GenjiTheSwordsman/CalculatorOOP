using NUnit.Framework;
using System;

namespace CalculatorOOP.Tests.TwoArgumentFunction
{
    [TestFixture]
    class TwoArgumentsFactoryTests
    {
        [TestCase("button1", typeof(AdditionCalculator))]
        [TestCase("button2", typeof(DivisionCalculator))]
        [TestCase("button3", typeof(MultiplyCalculator))]
        [TestCase("button4", typeof(SubtractionCalculator))]
        [TestCase("button7", typeof(MinCalculate))]
        [TestCase("button8", typeof(MaxCalculate))]
        [TestCase("button9", typeof(MiddleArithmeticCalculate))]
        [TestCase("button10", typeof(MiddleGeometricCalculate))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalc(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
