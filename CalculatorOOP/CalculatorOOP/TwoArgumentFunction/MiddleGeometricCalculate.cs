using System;
namespace CalculatorOOP
{
    public class MiddleGeometricCalculate : ITwoArgumentsCalculator
    {
        public double Calculate(double ArOne, double ArTwo)
        {
            return Math.Sqrt(ArOne * ArTwo);
        }

    }
}
