using System;
namespace CalculatorOOP
{
    public class LogarithmCalculate : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            return Math.Log(Number,2) ;
        }
    }
}
