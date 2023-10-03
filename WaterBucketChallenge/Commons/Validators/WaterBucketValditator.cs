using WaterBucketChallenge.Commons.Exceptions;
using WaterBucketChallenge.Commons.Helpers;

namespace WaterBucketChallenge.Commons.Validators
{
    public class WaterBucketValditator : IWaterBucketValditator
    {
        public string Validate(int x, int y, int z)
        {
            string valid = "";

            if (!ValuesArePositive(x, y, z))
                valid = "No solution, values most be positives";

            if (!ValuesAreSmall(x, y, z))
                valid = "No solution, values should be smaller";

            if (!ZIsLower(x, y, z))
                valid = "No solution, Z value should not be greater than Y and X";

            if (!IsDivisible(x, y, z))
                valid = "No solution, the Greatest Common Divisor of X and Y should be able to divide Z";

            return valid;
        }

        public bool ValuesArePositive(int x, int y, int z)
        {
            return (x >= 0 && y >= 0 && z >= 0);
        }

        public bool ValuesAreSmall(int x, int y, int z)
        {
            int maxLenght = EnvironmentHelper.GetEnv<int>("MAX_NUMBER", 1000);
            return (x <= maxLenght && y <= maxLenght && z <= maxLenght);
        }

        public bool ZIsLower(int x, int y, int z)
        {
            return z < Math.Max(x, y);
        }

        public bool IsDivisible(int x, int y, int z)
        {
            return ((z % NumberHelper.GreatestCommonDivisor(y, x)) == 0);
        }

       
    }
}
