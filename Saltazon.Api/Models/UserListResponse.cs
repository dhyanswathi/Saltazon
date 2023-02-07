using System.Text.Json.Serialization;

namespace Saltazon.Api.Models
{
    public class UserListResponse
    {
        [JsonPropertyName("data")]
        public IList<User> Users { get; set; }
    }
}
