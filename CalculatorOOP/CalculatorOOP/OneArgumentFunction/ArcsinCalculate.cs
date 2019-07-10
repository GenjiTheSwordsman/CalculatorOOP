using System;

namespace CalculatorOOP
{
    public class ArcsinCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Asin(Number);
        }
    }
}
