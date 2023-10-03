namespace WaterBucketChallenge.Commons.Helpers
{
    public class NumberHelper
    {
        public static int GreatestCommonDivisor(int number1, int number2)
        {
            if (number2 == 0)
                return number1;

            return GreatestCommonDivisor(number2, number1 % number2);
        }
    }
}
