namespace CalculatorOOP
{
    public class SubtractionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double ArOne, double ArTwo)
        {
            return ArOne / ArTwo;
        }
    }
}
