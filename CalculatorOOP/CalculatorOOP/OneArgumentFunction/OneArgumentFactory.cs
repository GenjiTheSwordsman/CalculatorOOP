using System;

namespace CalculatorOOP
{
    public static class OneArgumentFactory
    {
        /// <summary>
        /// trasfer the string argument in factory of one argument calculators
        /// </summary>
        /// <param name="name"> "name" is argument of button </param>
        /// <returns></returns>
        public static IOneArgumentCalculate CreateFac(string name)
        {
            switch (name)
            {
                case "PowCalculate":
                    return new PowCalculate();
                case "SqrtCalculate":
                    return new SqrtCalculate();
                case "SinCalculate":
                    return new SinCalculate();
                case "CosCalculate":
                    return new CosCalculate();
                case "TanCalculate":
                    return new TanCalculate();
                case "ArcsinCalculate":
                    return new ArcsinCalculate();
                case "ArccosCalculate":
                    return new ArccosCalculate();
                case "CtanCalculate":
                    return new CtanCalculate();
                case "ArctanCalculate":
                    return new ArctanCalculate();
                case "OneDivArgCalculate":
                    return new OneDivArgCalculate();
                case "ExponentialCalculate":
                    return new ExponentialCalculate();
                case "LogarithmCalculate":
                    return new LogarithmCalculate();
                case "LogarithmToTheBaseTenCalculate":
                    return new LogarithmToTheBaseTenCalculate();
                case "NaturalLogarithmCalculate":
                    return new NaturalLogarithmCalculate();
                case "ModuleNumberCalculate":
                    return new ModuleNumberCalculate();
                case "NegativeNumberCalculate":
                    return new NegativeNumberCalculate();
                case "TwoPowerNumberCalculate":
                    return new TwoPowerNumberCalculate();
                case "TenPowerNumberCalculate":
                    return new TenPowerNumberCalculate();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
