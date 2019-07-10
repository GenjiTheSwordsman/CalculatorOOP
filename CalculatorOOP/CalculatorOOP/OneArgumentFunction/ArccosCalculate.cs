using System;

namespace CalculatorOOP
{
    public class ArccosCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Acos(Number);
        }
    }
}
