using System;

namespace CalculatorOOP
{
    public class CosCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            return Math.Cos(number);
        }
    }
}
