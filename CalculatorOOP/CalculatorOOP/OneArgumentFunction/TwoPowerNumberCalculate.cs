using System;
namespace CalculatorOOP
{
    public class TwoPowerNumberCalculate : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            return Math.Pow(2,Number);
        }
    }
}

