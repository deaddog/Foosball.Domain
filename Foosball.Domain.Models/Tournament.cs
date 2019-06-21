using Foosball.Domain.Models.Tournaments;
using System;

namespace Foosball.Domain.Models
{
    public class Tournament
    {
        public Tournament(Id<Tournament> id, IScoring scoring, IRuleSet ruleSet)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));

            Scoring = scoring ?? throw new ArgumentNullException(nameof(scoring));
            RuleSet = ruleSet ?? throw new ArgumentNullException(nameof(ruleSet));
        }

        public Id<Tournament> Id { get; }

        public IScoring Scoring { get; }
        public IRuleSet RuleSet { get; }
    }
}
