namespace CalculatorOOP
{
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double ArOne, double ArTwo)
        {
            return ArOne * ArTwo;
        }
    }
}
