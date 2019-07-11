using System;
namespace CalculatorOOP
{
    public class MiddleGeometricCalculate : ITwoArgumentsCalculate
    {
        public double TwoArgCalculate(double arOne, double arTwo)
        {
            return Math.Sqrt(arOne * arTwo);
        }

    }
}
