using System;

namespace CalculatorOOP
{
    public class ArcsinCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            if (number < -1 || number > 1)
            {
                throw new Exception("Аркcинус не вычисляется");
            }
            else
            {
                return Math.Asin(number);
            }
        }
    }
}
