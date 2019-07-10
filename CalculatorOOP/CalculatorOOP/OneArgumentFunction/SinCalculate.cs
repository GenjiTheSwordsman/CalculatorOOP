using System;

namespace CalculatorOOP
{
    public class SinCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Sin(Number);
        }
    }
}
