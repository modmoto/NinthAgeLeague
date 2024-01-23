using System.Threading.Tasks;

namespace NinthAgeCmsToArmyBook.Api.ReadModelBase
{
    public interface IVersionRepository
    {
        Task<HandlerVersion> GetLastVersion<T>();
        Task SaveLastVersion<T>(HandlerVersion lastVersion);
    }
}