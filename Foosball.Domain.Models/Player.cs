using System;

namespace Foosball.Domain.Models
{
    public class Player
    {
        public Player(Id<Player> id)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        public Id<Player> Id { get; }
    }
}
