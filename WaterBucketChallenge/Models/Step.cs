using WaterBucketChallenge.Commons.Helpers;
using WaterBucketChallenge.Commons.Structs;

namespace WaterBucketChallenge.Models
{
    public class Step
    {
        public int Number { get; set; }
        public string Action { get; set; }
        public int Value { get; set; }
        public Bucket AffedtedBucket { get; set; }
        public Bucket? ToBucket { get; set; }
        public string Description { get; set; }

        public Step() { }

        public Step(string description) 
        {
            Description = description;
        }

        public Step(int number, string action,int value, Bucket affectedBucket, Bucket? toBucket = null)
        {
            Number = number;
            Action = action;
            Value = value;
            AffedtedBucket = ObjectHelper.Clone(affectedBucket);
            if(toBucket != null) ToBucket = ObjectHelper.Clone(toBucket);
            Description = GetDescription(action, value, affectedBucket, toBucket);
        }

        private string GetDescription(string action, int value, Bucket affectedBucket, Bucket? toBucket = null)
        {
            string description = string.Empty;
            if (action == ActionStep.Fill) 
                description = $"Filled {value} to bucket {affectedBucket.Name}";

            if (action == ActionStep.Empty) 
                description = $"Dumped {value} from bucket {affectedBucket.Name}";

            if (action == ActionStep.Transfer && toBucket != null) 
                description = $"Transfer {value} from bucket {affectedBucket.Name} to bucket {toBucket.Name}";

            return description;
        }
    }
}
