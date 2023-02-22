using Saltazon.Api.Models;

namespace Saltazon.Api.Services
{
    public interface IStoreClient
    {
        Task<StoreResponse?> GetStore(int id);
        Task<StoreListResponse?> GetAllStores();
        Task<ProductListResponse?> GetAllProducts();

        Task<ProductResponse?> GetProduct(int id);
        Task<ProductResponse?> Register(ProductRegisterRequest productRegister, int storeId);
        //Task<ProductResponse?> UpdateProduct(ProductRegisterRequest productUpdate, int storeId, int id);
        Task DeleteProduct(int id);
    }
}
