using System;

namespace Foosball.Domain.Models.Matches
{
    public class TimeConfiguration : IConfiguration
    {
        public TimeConfiguration(TimeSpan duration)
        {
            if (duration <= TimeSpan.Zero) throw new ArgumentOutOfRangeException(nameof(duration), "Match duration must be greater than zero.");

            Duration = duration;
        }

        public TimeSpan Duration { get; }
    }
}
