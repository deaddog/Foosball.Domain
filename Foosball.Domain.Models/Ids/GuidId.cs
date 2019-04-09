using System;

namespace Foosball.Domain.Models.Ids
{
    public class GuidId<T> : Id<T>, IEquatable<GuidId<T>>
    {
        public static GuidId<T> NewGuid() => new GuidId<T>(Guid.NewGuid());

        public GuidId(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Guid.Empty not allowed as unique identifier.", nameof(id));

            Id = id;
        }

        public Guid Id { get; }

        public override bool Equals(Id<T> other)
        {
            return Equals(other as GuidId<T>);
        }
        public bool Equals(GuidId<T> other)
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
