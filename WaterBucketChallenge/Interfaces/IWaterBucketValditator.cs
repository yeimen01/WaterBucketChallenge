namespace WaterBucketChallenge.Commons.Validators
{
    public interface IWaterBucketValditator
    {
        public string Validate(int x, int y, int z);

        public bool ValuesArePositive(int x, int y, int z);

        public bool ValuesAreSmall(int x, int y, int z);

        public bool ZIsLower(int x, int y, int z);

        public bool IsDivisible(int x, int y, int z);
    }
}