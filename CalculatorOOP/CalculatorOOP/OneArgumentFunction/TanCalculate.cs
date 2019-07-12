using System;

namespace CalculatorOOP
{
    public class TanCalculate : IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate tan of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            return Math.Tan(number);
        }
    }
}
