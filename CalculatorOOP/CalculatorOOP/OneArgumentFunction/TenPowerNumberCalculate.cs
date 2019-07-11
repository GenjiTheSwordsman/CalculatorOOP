using System;
namespace CalculatorOOP
{
    public class TenPowerNumberCalculate : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            return Math.Pow(10,Number);
        }
    }
}

