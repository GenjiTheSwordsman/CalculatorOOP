using System;

namespace CalculatorOOP
{
    public class SinCalculate : IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate sin of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            return Math.Sin(number);
        }
    }
}
