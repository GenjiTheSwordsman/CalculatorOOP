using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOP
{
    public class Pow:InterfaceForPowAndSQRT
    {
        public double forSqrtAndPow(double Number)
        {
            return Number * Number;
        }
    }
}
