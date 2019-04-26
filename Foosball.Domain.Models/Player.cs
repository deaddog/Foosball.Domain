using System;

namespace Foosball.Domain.Models
{
    public class Player
    {
        public Player(Id<Player> id, string name)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Name = name;
        }

        public Id<Player> Id { get; }
        public string Name { get; }
    }
}
