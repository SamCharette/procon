using System;
using procon.Features.Reasons.Value_Objects;

namespace procon.Features.Reasons
{
    public class Reason
    {
        private Guid _id;
        public Description Description { get; private set; }
        public Weight Weight { get; private set; }
        public Probability Probability { get; private set; }

        public Reason(Description description, Weight weight, Probability probability)
        {
            _id = Guid.NewGuid();
            Description = description;
            Weight = weight;
            Probability = probability;
        }

        public Reason(Description description)
        {
            _id = Guid.NewGuid();
            Description = description;
            Weight = new Weight(1);
            Probability = new Probability(100);
        }

        public bool IsPro() => Weight.Value() > 0;
        public bool IsCon() => !IsPro();

    }
}
