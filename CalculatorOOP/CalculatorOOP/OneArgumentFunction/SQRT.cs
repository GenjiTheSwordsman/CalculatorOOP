using System;

namespace CalculatorOOP
{
    public class SQRT : IOneArgumentCalculate
    {
        public double Calculte(double number)
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
