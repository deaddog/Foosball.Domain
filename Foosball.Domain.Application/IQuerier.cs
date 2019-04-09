using System.Threading.Tasks;

namespace Foosball.Domain.Application
{
    public interface IQuerier<in TQuery, TResponse>
    {
        Task<TResponse> QueryAsync(TQuery query);
    }
}
