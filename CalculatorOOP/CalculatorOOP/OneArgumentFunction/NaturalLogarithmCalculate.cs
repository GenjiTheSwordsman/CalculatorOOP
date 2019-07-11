using System;
namespace CalculatorOOP
{
    public class NaturalLogarithmCalculate : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            return Math.Log(Number);
        }
    }
}
