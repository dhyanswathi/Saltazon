using Saltazon.Api.Models;

namespace Saltazon.Api.Services
{
    public interface IStoreClient
    {
        Task<StoreResponse?> GetStore(int id);
        Task<ProductListResponse?> GetAllProducts();

        Task<ProductResponse?> GetProduct(int id);
        Task<ProductResponse?> Register(ProductRegisterRequest productRegister);
    }
}
