using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
