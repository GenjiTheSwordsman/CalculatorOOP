using System;

namespace CalculatorOOP
{
    public class LogarithmCalculate : IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate Log of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            if (number <= 0)
            {
                throw new Exception("Число должно быть больше нуля");
            }
            return Math.Log(number, 2);
        }
    }
}
