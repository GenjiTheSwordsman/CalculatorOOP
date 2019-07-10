using System;
namespace CalculatorOOP
{
    public class LogarithmToTheBaseTenCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Log10(Number);
        }
    }
}
    
