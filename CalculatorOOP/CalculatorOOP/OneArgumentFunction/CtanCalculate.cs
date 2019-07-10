using System;

namespace CalculatorOOP
{
    public class CtanCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return 1/Math.Tan(Number);
        }
    }
}
