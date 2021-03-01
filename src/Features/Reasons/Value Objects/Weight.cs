using System;

namespace procon.Features.Reasons.Value_Objects
{
    public class Weight
    {
        private readonly int _weight;

        public Weight(int weight)
        {
            var absoluteWeight = Math.Abs(weight);
            if (absoluteWeight > 0 && absoluteWeight < 101)
            {
                _weight = weight;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    nameof(weight),
                    "Must be between 1 and 100, or -1 and -100");
            }
        }   

        public int Value() => _weight;
        public override string ToString()
        {
            return _weight.ToString();
        }
    }
}
