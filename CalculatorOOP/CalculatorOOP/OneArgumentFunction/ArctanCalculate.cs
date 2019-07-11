using System;

namespace CalculatorOOP
{
    public class ArctanCalculate : IOneArgumentCalculate
    {
        public double Calculte(double number)
        {
            if (number < (-Math.PI / 2) || number > (Math.PI / 2))
            {
                throw new Exception("Арктангенс не вычисляется");
            }
            else
            {
                return Math.Atan(number);
            }
        }
    }
}
