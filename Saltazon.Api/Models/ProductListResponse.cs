using System.Text.Json.Serialization;

namespace Saltazon.Api.Models
{
    public class ProductListResponse
    {
        [JsonPropertyName("data")]
        public IList<Product> Products { get; set; }
    }
}
