using System;
namespace CalculatorOOP
{
    public class TwoPowerNumberCalculate : IOneArgumentCalculate
    {
        public double Calculte(double number)
        {
            return Math.Pow(2,number);
        }
    }
}

