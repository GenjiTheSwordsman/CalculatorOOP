using System;

namespace CalculatorOOP
{
    public class SqrtCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            if(number < 0)
            { 
                throw new Exception("Аргумент меньше нуля");
            }
            else
            {
                return Math.Sqrt(number);
            }
        }
    }
}
