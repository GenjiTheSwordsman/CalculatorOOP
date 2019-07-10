using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOP
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalc(string name)
        {
            switch (name)
            {
                case "button1":
                    return new AdditionCalculator();
                case "button2":
                    return new DivisionCalculator();
                case "button3":
                    return new MultiplayCalculator();
                case "button4":
                    return new SubtractionCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
