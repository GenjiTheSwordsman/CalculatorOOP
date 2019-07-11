using System;

namespace CalculatorOOP
{
    public class SinCalculate : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            return Math.Sin(Number);
        }
    }
}
