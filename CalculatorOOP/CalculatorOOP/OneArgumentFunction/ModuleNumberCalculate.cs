using System;
namespace CalculatorOOP
{
    public class ModuleNumberCalculate : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            return Math.Abs(Number);
        }
    }
}

