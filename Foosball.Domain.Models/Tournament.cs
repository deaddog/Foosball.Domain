using Foosball.Domain.Models.Tournaments;
using System;

namespace Foosball.Domain.Models
{
    public class Tournament
    {
        public Tournament(Id<Tournament> id, IScoring scoring)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));

            Scoring = scoring ?? throw new ArgumentNullException(nameof(scoring));
        }

        public Id<Tournament> Id { get; }

        public IScoring Scoring { get; }
    }
}
