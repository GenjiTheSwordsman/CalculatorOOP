using System;
namespace CalculatorOOP
{
    public class ModuleNumberCalculate : IOneArgumentCalculate
    {
        public double Calculte(double number)
        {
            return Math.Abs(number);
        }
    }
}

