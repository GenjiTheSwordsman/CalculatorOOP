using System;

namespace CalculatorOOP
{
    public class ExponentialCalculate : IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate exp of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            return Math.Exp(number);
        }
    }
}
