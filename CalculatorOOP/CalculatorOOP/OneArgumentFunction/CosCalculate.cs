using System;

namespace CalculatorOOP
{
    public class CosCalculate : IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate cos of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            return Math.Cos(number);
        }
    }
}
