using System.Text.Json.Serialization;

namespace Saltazon.Api.Models
{
    public class ProductResponse
    {
        [JsonPropertyName("data")]
        public Product Product { get; set; }
    }
}
