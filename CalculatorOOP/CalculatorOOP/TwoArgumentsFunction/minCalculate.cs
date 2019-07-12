namespace CalculatorOOP
{
    public class MinCalculate : ITwoArgumentsCalculate
    {
        public double TwoArgCalculate(double arOne, double arTwo)
        {
            if (arOne < arTwo) return arOne;
            return arTwo;
        }
    }
}
