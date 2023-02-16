using System.Text.Json.Serialization;

namespace Saltazon.Api.Models
{
    public class StoreResponse
    {
        [JsonPropertyName("data")]
        public Store Store { get; set; }
    }
}
