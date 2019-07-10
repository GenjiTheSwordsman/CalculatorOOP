using System;

namespace CalculatorOOP
{
    public class CosCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Cos(Number);
        }
    }
}
