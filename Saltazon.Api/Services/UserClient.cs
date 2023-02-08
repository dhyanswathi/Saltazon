using Saltazon.Api.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Saltazon.Api.Services
{
    public class UserClient : IUserClient
    {
        static HttpClient client = new HttpClient();

        const string UserUrl = "http://localhost:8000/api/user/";
        private HttpClient getClient()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
        public async Task<UserListResponse?> GetUsers()
        {
            var client = getClient();
            var usersTask = client.GetStreamAsync(UserUrl);
            return await JsonSerializer.DeserializeAsync<UserListResponse?>(await usersTask);
        }
        public async Task<UserResponse?> GetUser(int id)
        {
            var client = getClient();
            var url = $"{UserUrl}{id}";

            var userTask = client.GetStreamAsync(url);

            return await JsonSerializer.DeserializeAsync<UserResponse?>(await userTask);
        }

        public async Task<UserResponse?> Register(User user)
        {
            var url = "http://localhost:8000/api/user/";

            var response = await client.PostAsJsonAsync(url, user);
            var result = await response.Content.ReadFromJsonAsync<UserResponse?>();

            return result;
        }
    }
}
