using System;

namespace CalculatorOOP
{
    public class ArctanCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            return Math.Atan(number);
        }
    }
}
