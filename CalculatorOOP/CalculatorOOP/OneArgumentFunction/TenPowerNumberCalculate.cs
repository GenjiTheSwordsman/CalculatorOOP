using System;
namespace CalculatorOOP
{
    public class TenPowerNumberCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            return Math.Pow(10,number);
        }
    }
}

