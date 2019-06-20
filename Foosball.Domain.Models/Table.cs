using System;

namespace Foosball.Domain.Models
{
    public class Table
    {
        public Table(Id<Table> id)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        public Id<Table> Id { get; }
    }
}
