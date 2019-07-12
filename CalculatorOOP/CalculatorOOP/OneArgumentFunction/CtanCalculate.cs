using System;

namespace CalculatorOOP
{
    public class CtanCalculate : IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate Ctan of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            return 1/Math.Tan(number);
        }
    }
}
