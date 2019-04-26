using Foosball.Domain.Models;
using System;

namespace Foosball.Domain.Application.Commands.Tournaments
{
    public class NextRound
    {
        public NextRound(Id<Tournament> tournament)
        {
            Tournament = tournament ?? throw new ArgumentNullException(nameof(tournament));
        }

        public Id<Tournament> Tournament { get; }
    }
}
