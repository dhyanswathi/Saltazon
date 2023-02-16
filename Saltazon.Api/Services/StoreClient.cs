using Saltazon.Api.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Saltazon.Api.Services
{
    public class StoreClient : IStoreClient
    {
        static HttpClient client = new HttpClient();

        const string StoreUrl = "http://localhost:8000/api/store/";
        const string ProductUrl = "http://localhost:8000/api/product/";

        private HttpClient getClient()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
        public async Task<StoreResponse?> GetStore(int id)
        {
            var client = getClient();
            var url = $"{StoreUrl}{id}";

            var storeTask = client.GetStreamAsync(url);

            return await JsonSerializer.DeserializeAsync<StoreResponse?>(await storeTask);
        }

        public async Task<ProductListResponse?> GetAllProducts()
        {
            var client = getClient();
            var productsTask = client.GetStreamAsync(ProductUrl);
            return await JsonSerializer.DeserializeAsync<ProductListResponse?>(await productsTask);
        }

        public async Task<ProductResponse?> GetProduct(int id)
        {
            var client = getClient();
            var url = $"{ProductUrl}{id}";

            var productTask = client.GetStreamAsync(url);

            return await JsonSerializer.DeserializeAsync<ProductResponse?>(await productTask);
        }
    }
}
