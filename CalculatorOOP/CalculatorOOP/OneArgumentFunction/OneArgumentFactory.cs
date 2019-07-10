using System;

namespace CalculatorOOP
{
    public static class FactoryForSqrtAndPow
    {
        public static INterfaceForPowAndSQRT CreateFac(string name)
        {
            switch (name)
            {
                case "button5":
                    return new Pow();
                case "button6":
                    return new SQRT();
                case "button11":
                    return new SinCalculate();
                case "button12":
                    return new CosCalculate();
                case "button13":
                    return new TanCalculate();
                case "button14":
                    return new ArcsinCalculate();
                case "button15":
                    return new ArccosCalculate();
                case "button16":
                    return new CtanCalculate();
                case "button17":
                    return new ArctanCalculate();
                case "button18":
                    return new OneDivArgCalculate();
                case "button19":
                    return new ExponentialCalculate();
                case "button20":
                    return new LogarithmCalculate();
                case "button21":
                    return new LogarithmToTheBaseTenCalculate();
                case "button22":
                    return new NaturalLogarithmCalculate();
                case "button23":
                    return new ModuleNumberCalculate();
                case "button24":
                    return new NegativeNumberCalculate();
                case "button25":
                    return new TwoPowerNumberCalculate();
                case "button26":
                    return new TenPowerNumberCalculate();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
