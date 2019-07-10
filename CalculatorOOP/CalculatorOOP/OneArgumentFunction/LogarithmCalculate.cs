using System;
namespace CalculatorOOP
{
    public class LogarithmCalculate : INterfaceForPowAndSQRT
    {
        public double Calculte(double Number)
        {
            return Math.Log(Number,2) ;
        }
    }
}
