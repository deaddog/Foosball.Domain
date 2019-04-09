using Foosball.Domain.Models.Exceptions;
using System;

namespace Foosball.Domain.Models.Matches
{
    public class State
    {
        public State(DateTime? started, DateTime? ended, int score1, int score2)
        {
            if (ended.HasValue && !started.HasValue) throw new ArgumentException($"{nameof(started)} must be set when {nameof(ended)} is set.");
            if (ended.HasValue && ended < started) throw new ArgumentException($"A match cannot end before it starts.");

            if (started.HasValue && started.Value.Kind != DateTimeKind.Utc) throw new ArgumentNotUtcException(nameof(started));
            if (ended.HasValue && ended.Value.Kind != DateTimeKind.Utc) throw new ArgumentNotUtcException(nameof(ended));

            if (score1 < 0) throw new ArgumentOutOfRangeException(nameof(score1));
            if (score2 < 0) throw new ArgumentOutOfRangeException(nameof(score2));

            Started = started;
            Ended = ended;

            Score1 = score1;
            Score2 = score2;
        }

        public bool HasStarted => Started.HasValue;
        public bool HasEnded => Ended.HasValue;

        public DateTime? Started { get; }
        public DateTime? Ended { get; }

        public int Score1 { get; }
        public int Score2 { get; }
    }
}
