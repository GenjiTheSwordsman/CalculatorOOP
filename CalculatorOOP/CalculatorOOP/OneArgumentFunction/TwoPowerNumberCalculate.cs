using System;

namespace CalculatorOOP
{
    public class TwoPowerNumberCalculate : IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate 2^x of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            return Math.Pow(2,number);
        }
    }
}

