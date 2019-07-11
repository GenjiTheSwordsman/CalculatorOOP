using System;

namespace CalculatorOOP
{
    public class TanCalculate : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            return Math.Tan(Number);
        }
    }
}
