using System;
namespace CalculatorOOP
{
    public class ExponentialCalculate : IOneArgumentCalculate
    {
        public double Calculte(double number)
        {
            return Math.Exp(number);
        }
    }
}
