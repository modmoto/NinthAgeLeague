using System.Threading.Tasks;

namespace NinthAgeCmsToArmyBook.Api.ReadModelBase
{
    public interface IAsyncUpdatable
    {
        Task<HandlerVersion> Update(HandlerVersion currentVersion);
        int WaitTimeInMs { get; }
    }
}