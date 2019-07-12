using System;

namespace CalculatorOOP
{
    public class TenPowerNumberCalculate : IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate 10^x of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            return Math.Pow(10,number);
        }
    }
}

