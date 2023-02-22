using System.Text.Json.Serialization;

namespace Saltazon.Api.Models
{
    public class LoginResponse
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int StoreId { get; set; }
        public string Token { get; set; }
    }
}
