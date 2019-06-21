using System;
using System.Collections.Immutable;

namespace Foosball.Domain.Models.Tournaments
{
    public class ThreeRoundsRuleSet : IRuleSet
    {
        public ThreeRoundsRuleSet(IImmutableList<Id<Player>> players)
        {
            if (players.Count < 2 || players.Count > 4) throw new ArgumentOutOfRangeException(nameof(players), $"Only 2-4 players supported.");
            Players = players ?? throw new ArgumentNullException(nameof(players));
        }

        public IImmutableList<Id<Player>> Players { get; }
    }
}
