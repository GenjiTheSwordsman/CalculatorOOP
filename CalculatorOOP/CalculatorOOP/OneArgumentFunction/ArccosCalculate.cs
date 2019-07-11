using System;

namespace CalculatorOOP
{
    public class ArccosCalculate : IOneArgumentCalculate
    {
        public double Calculte(double number)
        {
            if (number < 0 || number > Math.PI)
            {
                throw new Exception("Аркосинус не вычисляется");
            }
            else
            {
                return Math.Acos(number);
            }
        }
    }
}
