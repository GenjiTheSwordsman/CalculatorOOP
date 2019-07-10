namespace CalculatorOOP
{
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double ArOne, double ArTwo)
        {
            return ArOne + ArTwo;
        }
    }
}
