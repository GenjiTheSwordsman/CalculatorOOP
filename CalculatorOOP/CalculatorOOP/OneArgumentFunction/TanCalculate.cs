using System;

namespace CalculatorOOP
{
    public class TanCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Tan(Number);
        }
    }
}
