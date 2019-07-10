using System;
namespace CalculatorOOP
{
    public class TwoPowerNumberCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Pow(2,Number);
        }
    }
}

