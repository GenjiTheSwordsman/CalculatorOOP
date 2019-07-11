namespace CalculatorOOP
{
    public class AdditionCalculate : ITwoArgumentsCalculate
    {
        public double TwoArgCalculate(double arOne, double arTwo)
        {
            return arOne + arTwo;
        }
    }
}
