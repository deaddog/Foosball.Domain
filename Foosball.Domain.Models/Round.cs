using System;
using System.Collections.Immutable;

namespace Foosball.Domain.Models
{
    public class Round
    {
        public Round(Id<Round> id, IImmutableList<Id<Match>> matches)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));

            Matches = matches ?? throw new ArgumentNullException(nameof(matches));
        }

        public Id<Round> Id { get; }

        public IImmutableList<Id<Match>> Matches { get; }
    }
}
