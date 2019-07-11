﻿using System;
namespace CalculatorOOP
{
    public class NaturalLogarithmCalculate : IOneArgumentCalculate
    {
        public double OneArgCalculate(double number)
        {
            if (number <= 0)
            {
                throw new Exception("Число должно быть больше нуля");
            }
            else
            {
                return Math.Log(number);
            }
        }
    }
}
