using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOP
{
    public class MaxCalculate : ITwoArgumentsCalculate
    {
        public double TwoArgCalculate(double arOne, double arTwo)
        {
            if (arOne > arTwo) return arOne;
            return arTwo;
        }
    }
}
