using System;

namespace CalculatorOOP
{
    public class ArctanCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Atan(Number);
        }
    }
}
