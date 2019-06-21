using System;
using System.Collections.Immutable;

namespace Foosball.Domain.Models
{
    public class Round
    {
        public Round(Id<Round> id, IImmutableList<Id<Match>> matches, Id<Tournament> tournament)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Matches = matches ?? throw new ArgumentNullException(nameof(matches));
            Tournament = tournament ?? throw new ArgumentNullException(nameof(tournament));
        }

        public Id<Round> Id { get; }

        public IImmutableList<Id<Match>> Matches { get; }

        public Id<Tournament> Tournament { get; }
    }
}
