using System;

namespace CalculatorOOP
{
    public class CtanCalculate : IOneArgumentCalculate
    {
        public double Calculte(double number)
        {
            return 1/Math.Tan(number);
        }
    }
}
