using System;

namespace CalculatorOOP
{
    public class ArccosCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            if (number < -1 || number > 1)
            {
                throw new Exception("Арккосинус не вычисляется");
            }
            else
            {
                return Math.Acos(number);
            }
        }
    }
}
