using System;

namespace CalculatorOOP
{
    public class ArcsinCalculate : IOneArgumentCalculate
    {
        public double Calculte(double number)
        {
            if (number < (-Math.PI / 2) || number > (Math.PI/2))
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
