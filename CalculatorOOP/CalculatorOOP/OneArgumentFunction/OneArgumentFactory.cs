using System;

namespace CalculatorOOP
{
    public static class FactoryForSqrtAndPow
    {
        public static InterfaceForPowAndSQRT CreateFac(string name)
        {
            switch (name)
            {
                case "button5":
                    return new Pow();
                case "button6":
                    return new SQRT();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
