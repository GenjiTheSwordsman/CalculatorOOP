using System;
namespace CalculatorOOP
{
    public class NaturalLogarithmCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Log(Number);
        }
    }
}
