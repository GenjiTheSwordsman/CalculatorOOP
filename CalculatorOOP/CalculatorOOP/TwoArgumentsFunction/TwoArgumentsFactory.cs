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
                case "AdditionCalculate":
                    return new AdditionCalculate();
                case "SubstractionCalculate":
                    return new SubstractionCalculate();
                case "MultiplyCalculate":
                    return new MultiplyCalculate();
                case "DivisionCalculate":
                    return new DivisionCalculate();
                case "MinCalculate":
                    return new MinCalculate();
                case "MaxCalculate":
                    return new MaxCalculate();
                case "MiddleArithmeticCalculate":
                    return new MiddleArithmeticCalculate();
                case "MiddleGeometricCalculate":
                    return new MiddleGeometricCalculate();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
