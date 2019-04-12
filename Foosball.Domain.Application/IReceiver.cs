using System.Threading.Tasks;

namespace Foosball.Domain.Application
{
    public interface IReceiver<in TMessage>
    {
        Task Receive(TMessage message);
    }
}
