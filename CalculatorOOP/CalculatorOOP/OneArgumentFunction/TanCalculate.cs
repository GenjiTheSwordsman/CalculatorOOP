using System;

namespace CalculatorOOP
{
    public class TanCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            return Math.Tan(number);
        }
    }
}
