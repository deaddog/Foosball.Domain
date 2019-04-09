using System;

namespace Foosball.Domain.Models.Ids
{
    public class IntId<T> : Id<T>, IEquatable<IntId<T>>
    {
        public IntId(int id)
        {
            if (id == 0)
                throw new ArgumentException("Zero not allowed as unique identifier.", nameof(id));

            Id = id;
        }

        public int Id { get; }

        public override bool Equals(Id<T> other)
        {
            return Equals(other as IntId<T>);
        }
        public bool Equals(IntId<T> other)
        {
            return other != null && Id.Equals(other.Id);
        }

        protected override int GetIdHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
