using System;

namespace CalculatorOOP
{
    public class NaturalLogarithmCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            /// <summary>
            /// this function calculate Natural Log of first argument 
            /// </summary>
            /// <param name="number"></param>
            /// <returns></returns>
            if (number <= 0)
            {
                throw new Exception("Число должно быть больше нуля");
            }
            return Math.Log(number);
        }
    }
}
