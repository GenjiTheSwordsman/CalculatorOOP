using System;
namespace CalculatorOOP
{
    public class ExponentialCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            return Math.Exp(number);
        }
    }
}
