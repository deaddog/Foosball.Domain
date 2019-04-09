using System.Threading.Tasks;

namespace Foosball.Domain.Application
{
    public interface IExecutor<in TCommand>
    {
        Task ExecuteAsync(TCommand command);
    }
}
