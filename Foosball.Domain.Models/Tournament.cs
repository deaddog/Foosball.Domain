using Foosball.Domain.Models.Tournaments;
using System;
using System.Collections.Immutable;

namespace Foosball.Domain.Models
{
    public class Tournament
    {
        public Tournament(Id<Tournament> id, IImmutableList<Id<Table>> tables, IScoring scoring, RuleSet rules)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));

            Tables = tables ?? throw new ArgumentNullException(nameof(tables));
            Scoring = scoring ?? throw new ArgumentNullException(nameof(scoring));
            Rules = rules ?? throw new ArgumentNullException(nameof(rules));
        }

        public Id<Tournament> Id { get; }

        public IImmutableList<Id<Table>> Tables { get; }
        public IScoring Scoring { get; }
        public RuleSet Rules { get; }
    }

    public class RuleSet
    {
        public Matches.IConfiguration Configuration { get; }
        public Tournaments.Rules.CanAddRoundRule CanAddRound {get;}
    }
}
