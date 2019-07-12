using System;

namespace CalculatorOOP
{
    public class OneDivArgCalculate : IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate 1/x of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            if (number == 0)
            {
                throw new Exception("Число не должно быть равно нулю");
            }
            return 1 / number;
        }
    }
}
