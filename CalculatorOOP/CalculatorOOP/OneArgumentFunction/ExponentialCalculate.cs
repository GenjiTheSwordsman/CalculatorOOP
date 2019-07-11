using System;
namespace CalculatorOOP
{
    public class ExponentialCalculate : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            return Math.Exp(Number);
        }
    }
}
