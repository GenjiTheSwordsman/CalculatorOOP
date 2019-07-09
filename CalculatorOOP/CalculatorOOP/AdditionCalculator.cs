﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOP
{
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double ArOne, double ArTwo)
        {
            return ArOne + ArTwo;
        }
    }
}
