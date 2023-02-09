using System.Text.Json.Serialization;

namespace Saltazon.Api.Models
{
    public class UserRegisterRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int StoreId { get; set; }
    }
}
