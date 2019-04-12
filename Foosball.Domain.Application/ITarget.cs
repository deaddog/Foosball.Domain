using System.Threading.Tasks;

namespace Foosball.Domain.Application
{
    public interface ITarget<in TMessage>
    {
        Task Post(TMessage message);
    }
}
