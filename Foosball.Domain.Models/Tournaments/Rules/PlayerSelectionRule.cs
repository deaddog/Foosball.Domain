using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Foosball.Domain.Models.Tournaments.Rules
{
    public class PlayerSelectionRule : IRule
    {
        public PlayerSelectionRule()
    }

    public class SelectPlayers
    {
        public SelectPlayers(Id<Tournament> tournament, IImmutableList<Player> availablePlayers)
        {
            Tournament = tournament ?? throw new ArgumentNullException(nameof(tournament));
            AvailablePlayers = availablePlayers ?? throw new ArgumentNullException(nameof(availablePlayers));
        }

        public Id<Tournament> Tournament { get; }
        public IImmutableList<Player> AvailablePlayers { get; }
    }
}
