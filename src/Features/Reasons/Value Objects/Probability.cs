using System.ComponentModel.DataAnnotations;

namespace procon.Features.Reasons.Value_Objects
{
    public class Probability
    {
        [Range(1,100)] private readonly int _value;

        public Probability(int value)
        {
            _value = value;
        }

        public int Value() => _value;
        public decimal ValueAsDecimal() => 1 / _value;

    }
}
