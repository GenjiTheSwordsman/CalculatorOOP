namespace CalculatorOOP 
{
    public class MiddleArithmetic : ITwoArgumentsCalculator
    {
        public double Calculate(double ArOne, double ArTwo)
        {
            return (ArOne + ArTwo) / 2;
        }
    }
}
