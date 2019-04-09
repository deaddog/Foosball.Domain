using System;

namespace Foosball.Domain.Models.Ids
{
    public class StringId<T> : Id<T>, IEquatable<StringId<T>>
    {
        public StringId(string id)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        public string Id { get; }

        public override bool Equals(Id<T> other)
        {
            return Equals(other as StringId<T>);
        }
        public bool Equals(StringId<T> other)
        {
            return other != null && Id.Equals(other.Id);
        }

        protected override int GetIdHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Id;
        }
    }
}
