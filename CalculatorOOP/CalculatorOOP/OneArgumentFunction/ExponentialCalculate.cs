using System;
namespace CalculatorOOP
{
    public class ExponentialCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Exp(Number);
        }
    }
}
