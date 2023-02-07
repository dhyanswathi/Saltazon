using Saltazon.Api.Models;

namespace Saltazon.Api.Services
{
    public interface IUserClient
    {
        Task<UserListResponse> getUsers();
        Task<UserResponse> getUser(int id);
    }
}
