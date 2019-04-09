using Foosball.Domain.Models;
using System;
using System.Collections.Immutable;

namespace Foosball.Domain.Application.Queries
{
    public class Get<T>
    {
        public Get(IImmutableList<Id<T>> ids)
        {
            Ids = ids ?? throw new ArgumentNullException(nameof(ids));
        }

        public IImmutableList<Id<T>> Ids { get; }
    }
}
