using System;

namespace CalculatorOOP
{
    public class ModuleNumberCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            return Math.Abs(number);
        }
    }
}

