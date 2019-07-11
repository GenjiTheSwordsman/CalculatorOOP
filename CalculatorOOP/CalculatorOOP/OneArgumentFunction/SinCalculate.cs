using System;

namespace CalculatorOOP
{
    public class SinCalculate : IOneArgumentCalculate
    {
        public double Calculte(double number)
        {
            return Math.Sin(number);
        }
    }
}
