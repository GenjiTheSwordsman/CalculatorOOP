using System;

namespace CalculatorOOP
{
    public class OneDivArgCalculate : IOneArgumentCalculate
    {
        public double Calculte(double number)
        {
            return 1 / number;
        }
    }
}
