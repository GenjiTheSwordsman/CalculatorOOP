using System;

namespace CalculatorOOP
{
    public class ArcsinCalculate : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            return Math.Asin(Number);
        }
    }
}
