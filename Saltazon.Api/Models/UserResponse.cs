using System.Text.Json.Serialization;

namespace Saltazon.Api.Models
{
    public class UserResponse
    {
        [JsonPropertyName("data")]
        public User User { get; set; }
    }
}
