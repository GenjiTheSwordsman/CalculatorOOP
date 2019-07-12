namespace CalculatorOOP
{
    public class PowCalculate:IOneArgumentCalculate
    {
        /// <summary>
        /// this function calculate pow of first argument 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double OneArgCalculate(double number)
        {
            return number * number;
        }
    }
}
