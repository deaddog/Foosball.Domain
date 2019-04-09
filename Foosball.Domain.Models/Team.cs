using System;
using System.Collections.Generic;

namespace Foosball.Domain.Models
{
    public class Team : IEquatable<Team>
    {
        public Team(Id<Player> player1, Id<Player> player2)
        {
            Player1 = player1 ?? throw new ArgumentNullException(nameof(player1));
            Player2 = player2 ?? throw new ArgumentNullException(nameof(player2));
        }

        public Id<Player> Player1 { get; }
        public Id<Player> Player2 { get; }

        public static bool operator ==(Team team1, Team team2) => EqualityComparer<Team>.Default.Equals(team1, team2);
        public static bool operator !=(Team team1, Team team2) => !(team1 == team2);

        public override bool Equals(object obj)
        {
            return Equals(obj as Team);
        }
        public bool Equals(Team other)
        {
            return other != null &&
                Player1.Equals(other.Player1) &&
                Player2.Equals(other.Player2);
        }

        public override int GetHashCode()
        {
            return Player1.GetHashCode() ^ Player2.GetHashCode();
        }

        public override string ToString()
        {
            return $"{{{Player1}, {Player2}}}";
        }
    }
}
