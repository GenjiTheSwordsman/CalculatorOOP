using System;
namespace CalculatorOOP
{
    public class ModuleNumberCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Abs(Number);
        }
    }
}

