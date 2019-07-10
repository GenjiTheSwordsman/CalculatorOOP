using System;
namespace CalculatorOOP
{
    public class TenPowerNumberCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Pow(10,Number);
        }
    }
}

