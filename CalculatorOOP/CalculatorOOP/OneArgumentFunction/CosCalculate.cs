using System;

namespace CalculatorOOP
{
    public class CosCalculate : IOneArgumentCalculate
    {
        public double Calculte(double number)
        {
            return Math.Cos(number);
        }
    }
}
