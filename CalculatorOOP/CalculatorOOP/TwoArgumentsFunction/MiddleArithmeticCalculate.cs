namespace CalculatorOOP 
{
    public class MiddleArithmeticCalculate : ITwoArgumentsCalculate
    {
        public double TwoArgCalculate(double arOne, double arTwo)
        {
            return (arOne + arTwo) / 2;
        }
    }
}
