using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Saltazon.Api.Models;
using Saltazon.Api.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Saltazon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static readonly string[] Roles = new[]
        {
            "admin", "super-admin", "user"
        };

        private readonly IUserClient _userClient;
        private readonly ILogger<UserController> _logger;
        private readonly ITokenManager _tokenManager;
        public UserController(ILogger<UserController> logger, IUserClient userClient, ITokenManager tokenManager)
        {
            _logger = logger;
            _userClient = userClient;
            _tokenManager = tokenManager;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<ActionResult> GetUserAsync(int id)
        {
            try
            {
                var user = await _userClient.GetUser(id);

                return Ok(user);
            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());
            }
        }

        [HttpPost("register")]
        public async Task<ActionResult> PostUserAsync (UserRegisterRequest user)
        {
           var result =  await _userClient.Register(user);
            return Created("", user.Email);
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(UserLoginRequest userLogin)
        {
            var result = await _userClient.GetUsers();
            var user = result?.Users.ToList().FirstOrDefault(x=>x.Email == userLogin.Email);

            if (user != null && user.Password == userLogin.Password)
            {
                var token = _tokenManager.Authenticate(userLogin.Email, userLogin.Password);
                if (token == null)
                {
                    return Unauthorized();
                }
                var loginUser = new LoginResponse
                {
                    Id = user.Id,
                    Email= user.Email,
                    Role = user.Role,
                    StoreId = user.StoreId,
                    Token= token,

                };
                return Ok(loginUser);
            }

            return Unauthorized("Email or password is incorrect");
        }
    }
}
