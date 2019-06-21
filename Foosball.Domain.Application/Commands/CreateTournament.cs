using Foosball.Domain.Models;
using System;

namespace Foosball.Domain.Application.Commands
{
    public class CreateTournament
    {
        public CreateTournament(Tournament tournament)
        {
            Tournament = tournament ?? throw new ArgumentNullException(nameof(tournament));
        }

        public Tournament Tournament { get; }
    }
}
