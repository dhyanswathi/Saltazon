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

        public async Task<ProductResponse?> Register(ProductRegisterRequest productRegister, int storeId)
        {
            var product = new Product
            {
                Id = GetAllProducts().Result.Products.OrderByDescending(x => x.Id).First().Id + 1,
                Title= productRegister.Title,
                Description= productRegister.Description,
                ImageUrl= productRegister.ImageUrl,
                Price= productRegister.Price,
                Category= productRegister.Category,
                Quantity= productRegister.Quantity,
                StoreId = storeId,
            };

            var response = await client.PostAsJsonAsync(ProductUrl, product);
            var result = await response.Content.ReadFromJsonAsync<ProductResponse?>();

            return result;
        }

        //public async Task<ProductResponse?> UpdateProduct(ProductRegisterRequest productUpdate, int storeId, int id)
        //{
        //    var product = await GetProduct(id);

        //}

        public async Task DeleteProduct(int id)
        {
            var url = $"{ProductUrl}{id}";

            var response = await client.DeleteAsync(url);
        }
    }
}
