using System;

namespace CalculatorOOP
{
    public class DivisionCalculate : ITwoArgumentsCalculate
    {
        public double TwoArgCalculate(double arOne, double arTwo)
        {
            if (arTwo == 0)
            {
                throw new Exception("Деление на 0");
            }
            else
            {
                return arOne / arTwo;
            }
        }
    }
}
