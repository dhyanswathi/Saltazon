using Saltazon.Api.Models;

namespace Saltazon.Api.Services
{
    public interface IStoreClient
    {
        Task<StoreResponse?> GetStore(int id);
    }
}
