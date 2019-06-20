using Foosball.Domain.Application.Queries;
using Foosball.Domain.Models;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;

namespace Foosball.Domain.Application
{
    public static class QuerierExtensions
    {
        public static Task<TItem> GetSingleAsync<TItem>(this IQuerier<Get<TItem>, IImmutableList<TItem>> queryHandler, Id<TItem> id)
        {
            return queryHandler.QueryAsync(new Get<TItem>(ImmutableList.Create(id))).ContinueWith(t => System.Linq.Enumerable.Single(t.Result));
        }

        public static Task<IImmutableList<TResponse>> GetAsync<TQuery, TResponse>(this IQuerier<Get<TQuery>, IImmutableList<TResponse>> queryHandler, params Id<TQuery>[] ids)
        {
            return queryHandler.QueryAsync(new Get<TQuery>(ids.ToImmutableList()));
        }
        public static Task<IImmutableList<TResponse>> GetAsync<TQuery, TResponse>(this IQuerier<Get<TQuery>, IImmutableList<TResponse>> queryHandler, IEnumerable<Id<TQuery>> ids)
        {
            return queryHandler.QueryAsync(new Get<TQuery>(ids.ToImmutableList()));
        }

        public static Task<IImmutableList<TResponse>> SearchAsync<TResponse>(this IQuerier<Search, IImmutableList<TResponse>> queryHandler, string text)
        {
            return queryHandler.QueryAsync(new Search(text));
        }
    }
}
