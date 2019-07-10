using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOP
{
    public class MinCalculate : ITwoArgumentsCalculator
    {
        public double Calculate(double ArOne, double ArTwo)
        {
            if (ArOne < ArTwo) return ArOne;
            return ArTwo;
        }
    }
}
