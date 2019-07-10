using System;

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
                case "button7":
                    return new MinCalculate();
                case "button8":
                    return new MaxCalculate();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
