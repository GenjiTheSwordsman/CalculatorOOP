using System;

namespace CalculatorOOP
{
    public class SinCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            return Math.Sin(number);
        }
    }
}
