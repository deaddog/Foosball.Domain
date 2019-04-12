using System;

namespace Foosball.Domain.Models
{
    public class Score : IComparable<Score>
    {
        public Score(Id<Player> player, int totalPoints)
        {
            Player = player ?? throw new ArgumentNullException(nameof(player));
            TotalPoints = totalPoints;
        }

        public Id<Player> Player { get; }
        public int TotalPoints { get; }

        public int CompareTo(Score other)
        {
            return TotalPoints.CompareTo(other.TotalPoints);
        }
    }
}
