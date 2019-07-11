using System;

namespace CalculatorOOP
{
    public class OneDivArgCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            if (number == 0)
            {
                throw new Exception("Число не должно быть равно нулю");
            }
            else
            {
                return 1 / number;
            }
        }
    }
}
