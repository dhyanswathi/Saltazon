using Saltazon.Api.Models;

namespace Saltazon.Api.Services
{
    public interface IUserClient
    {
        Task<UserListResponse?> GetUsers();
        Task<UserResponse?> GetUser(int id);
        Task<UserResponse?> Register(User user);

    }
}
