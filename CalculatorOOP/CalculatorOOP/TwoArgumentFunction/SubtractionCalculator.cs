using System;

namespace CalculatorOOP
{
    public class SubtractionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double ArOne, double ArTwo)
        {
            if (ArTwo == 0)
            {
                throw new Exception("Деление на 0");
            }
            else
            {
                return ArOne / ArTwo;
            }
        }
    }
}
