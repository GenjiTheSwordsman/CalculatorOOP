﻿using System;

namespace CalculatorOOP
{
    public class SQRT : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Sqrt(Number);
        }
    }
}
