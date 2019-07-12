using System;

namespace CalculatorOOP
{
    public class ArcsinCalculate : IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate Arsin of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            if (number < -1 || number > 1)
            {
                throw new Exception("Аркcинус не вычисляется");
            }
            return Math.Asin(number);
        }
    }
}
