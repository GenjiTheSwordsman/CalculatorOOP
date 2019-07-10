namespace CalculatorOOP 
{
    public class MiddleArithmeticCalculate : ITwoArgumentsCalculator
    {
        public double Calculate(double ArOne, double ArTwo)
        {
            return (ArOne + ArTwo) / 2;
        }
    }
}
