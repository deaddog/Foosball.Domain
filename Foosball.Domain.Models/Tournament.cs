using System;

namespace Foosball.Domain.Models
{
    public class Tournament
    {
        public Tournament(Id<Tournament> id)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        public Id<Tournament> Id { get; }
    }
}
