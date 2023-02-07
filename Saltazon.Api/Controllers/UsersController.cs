using Microsoft.AspNetCore.Mvc;
using Saltazon.Api.Models;
using Saltazon.Api.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Saltazon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static readonly string[] Roles = new[]
        {
            "admin", "super-admin", "user"
        };

        private readonly IUserClient _userClient;
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger, IUserClient userClient)
        {
            _logger = logger;
            _userClient = userClient;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<ActionResult<UserListResponse>> GetUserListAsync()
        {
            try
            {
                var userListResponse = await _userClient.getUsers();

                return userListResponse;

            }
            catch (System.Exception ex)
            {
                return NotFound(ex.ToString());
            }
        }
    }
}
