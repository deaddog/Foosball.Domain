using System;

namespace Foosball.Domain.Models.Matches
{
    public class TargetScoreConfiguration : IConfiguration
    {
        public TargetScoreConfiguration(int target)
        {
            if (target <= 0) throw new ArgumentOutOfRangeException(nameof(target), "Match target score must be greater than zero.");

            Target = target;
        }

        public int Target { get; }
    }
}
