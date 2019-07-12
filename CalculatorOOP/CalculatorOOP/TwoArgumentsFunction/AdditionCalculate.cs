namespace CalculatorOOP
{
    public class AdditionCalculate : ITwoArgumentsCalculate
    {
        /// <summary>
        /// this function calculate summary of first and second arguments 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double TwoArgCalculate(double arOne, double arTwo)
        {
            return arOne + arTwo;
        }
    }
}
