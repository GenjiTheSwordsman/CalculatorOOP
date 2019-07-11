using System;

namespace CalculatorOOP
{
    public class TanCalculate : IOneArgumentCalculate
    {
        public double Calculte(double number)
        {
            return Math.Tan(number);
        }
    }
}
