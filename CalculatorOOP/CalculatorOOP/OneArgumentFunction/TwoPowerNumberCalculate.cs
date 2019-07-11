using System;
namespace CalculatorOOP
{
    public class TwoPowerNumberCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            return Math.Pow(2,number);
        }
    }
}

