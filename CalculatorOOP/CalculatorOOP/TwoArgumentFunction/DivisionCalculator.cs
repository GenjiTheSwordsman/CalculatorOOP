namespace CalculatorOOP
{
    class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double ArOne, double ArTwo)
        {
            return ArOne - ArTwo;
        }
    }
}
