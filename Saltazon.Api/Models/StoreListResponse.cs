using System.Text.Json.Serialization;

namespace Saltazon.Api.Models
{
    public class StoreListResponse
    {
        [JsonPropertyName("data")]
        public IList<Store> Stores { get; set; }
    }
}
