namespace CalculatorOOP
{
    public class MaxCalculate : ITwoArgumentsCalculate
    {
        public double TwoArgCalculate(double arOne, double arTwo)
        {
            if (arOne > arTwo) return arOne;
            return arTwo;
        }
    }
}
