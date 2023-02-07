using Saltazon.Api.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Saltazon.Api.Services
{
    public class UserClient : IUserClient
    {
        private HttpClient getClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
        public async Task<UserListResponse> getUsers()
        {
            var client = getClient();
            var url = "http://localhost:8000/api/user/";
            var usersTask = client.GetStreamAsync(url);
            return await JsonSerializer.DeserializeAsync<UserListResponse>(await usersTask);
        }
        Task<User> IUserClient.getUser(int id)
        {
            throw new NotImplementedException();
        }
        //public async Task<User> getUser(int id)
        //{
        //    var url = $"http://localhost:8000/api/user/{id}";

        //}
    }
}
