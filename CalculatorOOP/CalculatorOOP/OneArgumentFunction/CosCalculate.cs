using System;

namespace CalculatorOOP
{
    public class CosCalculate : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            return Math.Cos(Number);
        }
    }
}
