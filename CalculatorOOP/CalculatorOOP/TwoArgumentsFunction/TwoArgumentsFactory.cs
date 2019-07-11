using System;

namespace CalculatorOOP
{
    public static class TwoArgumentsFactory
    {
        /// <summary>
        /// trasfer the string argument in factory of two arguments calculators
        /// </summary>
        /// <param name="name"> "name" is argument of button </param>
        /// <returns></returns>
        public static ITwoArgumentsCalculate CreateCalc(string name)
        {
            switch (name)
            {
                case "button1":
                    return new AdditionCalculate();
                case "button2":
                    return new SubstractionCalculate();
                case "button3":
                    return new MultiplyCalculate();
                case "button4":
                    return new DivisionCalculate();
                case "button7":
                    return new MinCalculate();
                case "button8":
                    return new MaxCalculate();
                case "button9":
                    return new MiddleArithmeticCalculate();
                case "button10":
                    return new MiddleGeometricCalculate();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
