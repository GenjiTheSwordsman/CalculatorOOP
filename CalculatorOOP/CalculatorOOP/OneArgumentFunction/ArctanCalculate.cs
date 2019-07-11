using System;

namespace CalculatorOOP
{
    public class ArctanCalculate : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            return Math.Atan(Number);
        }
    }
}
