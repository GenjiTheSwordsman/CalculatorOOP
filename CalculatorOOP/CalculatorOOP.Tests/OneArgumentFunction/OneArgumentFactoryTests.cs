using NUnit.Framework;
using System;

namespace CalculatorOOP.Tests
{ 
    [TestFixture]

    class OneArgumentFactoryTests
    {
        [TestCase("button5", typeof(PowCalculate))]
        [TestCase("button6", typeof(SqrtCalculate))]
        [TestCase("button11", typeof(SinCalculate))]
        [TestCase("button12", typeof(CosCalculate))]
        [TestCase("button13", typeof(TanCalculate))]
        [TestCase("button14", typeof(ArcsinCalculate))]
        [TestCase("button15", typeof(ArccosCalculate))]
        [TestCase("button16", typeof(CtanCalculate))]
        [TestCase("button17", typeof(ArctanCalculate))]
        [TestCase("button18", typeof(OneDivArgCalculate))]
        [TestCase("button19", typeof(ExponentialCalculate))]
        [TestCase("button20", typeof(LogarithmCalculate))]
        [TestCase("button21", typeof(LogarithmToTheBaseTenCalculate))]
        [TestCase("button22", typeof(NaturalLogarithmCalculate))]
        [TestCase("button23", typeof(ModuleNumberCalculate))]
        [TestCase("button24", typeof(NegativeNumberCalculate))]
        [TestCase("button25", typeof(TwoPowerNumberCalculate))]
        [TestCase("button26", typeof(TenPowerNumberCalculate))]
        public void CalculateTest (string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateFac(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}

