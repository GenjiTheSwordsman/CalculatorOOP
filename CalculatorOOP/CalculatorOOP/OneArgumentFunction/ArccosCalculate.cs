using System;

namespace CalculatorOOP
{
    public class ArccosCalculate : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            return Math.Acos(Number);
        }
    }
}
