using System;

namespace Foosball.Domain.Models.Exceptions
{
    public class ArgumentNotUtcException : ArgumentException
    {
        public ArgumentNotUtcException(string paramName) : base(message: $"{nameof(DateTime)} argument must have {nameof(DateTime.Kind)} = {nameof(DateTimeKind.Utc)}.", paramName: paramName)
        {
        }
    }
}
