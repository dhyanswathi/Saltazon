using Saltazon.Api.Models;

namespace Saltazon.Api.Services
{
    public interface IUserClient
    {
        Task<UserListResponse> getUsers();
        Task<User> getUser(int id);
    }
}
