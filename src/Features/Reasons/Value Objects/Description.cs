using System.ComponentModel.DataAnnotations;

namespace procon.Features.Reasons.Value_Objects
{
    public class Description
    {
        [MaxLength(250)] private readonly string _text;

        public Description(string description)
        {
            _text = description;
        }

        public override string ToString() => _text;
    }
}
