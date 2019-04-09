using System;
using System.Collections.Generic;

namespace Foosball.Domain.Models
{
    public abstract class Id<T> : IEquatable<Id<T>>
    {
        public sealed override bool Equals(object obj)
        {
            return Equals(obj as Id<T>);
        }
        public abstract bool Equals(Id<T> other);

        public sealed override int GetHashCode() => GetIdHashCode();
        protected abstract int GetIdHashCode();

        public static bool operator ==(Id<T> id1, Id<T> id2) => EqualityComparer<Id<T>>.Default.Equals(id1, id2);
        public static bool operator !=(Id<T> id1, Id<T> id2) => !(id1 == id2);
    }
}
