namespace CalculatorOOP
{
    public class MultiplayCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double ArOne, double ArTwo)
        {
            return ArOne * ArTwo;
        }
    }
}
