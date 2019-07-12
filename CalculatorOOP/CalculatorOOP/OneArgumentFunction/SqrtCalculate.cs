using System;

namespace CalculatorOOP
{
    public class SqrtCalculate : IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate sqrt of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            if(number < 0)
            { 
                throw new Exception("Аргумент меньше нуля");
            }
            return Math.Sqrt(number);
        }
    }
}
