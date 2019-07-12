using System;

namespace CalculatorOOP
{
    public class ArctanCalculate : IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate Arctan of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            return Math.Atan(number);
        }
    }
}
