using System;

namespace CalculatorOOP
{
    public class SQRT : IOneArgumentCalculate
    {
        public double Calculte(double Number)
        {
            try
            {
                double y = Math.Sqrt(Number);
                return y;
            }
            catch
            {
                throw new Exception("Аргумент меньше нуля");
            }
        }
    }
}
