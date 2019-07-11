using System;
namespace CalculatorOOP
{
    public class LogarithmToTheBaseTenCalculate : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            return Math.Log10(Number);
        }
    }
}
    
