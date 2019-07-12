using System;

namespace CalculatorOOP
{
    public class ArccosCalculate : IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate Arccos of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            if (number < -1 || number > 1)
            {
                throw new Exception("Арккосинус не вычисляется");
            }
            return Math.Acos(number);
        }
    }
}
