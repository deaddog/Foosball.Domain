using System;

namespace Foosball.Domain.Application.Queries
{
    public class Search
    {
        public Search(string text)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public string Text { get; }
    }
}
