using System.Text.Json.Serialization;

namespace Saltazon.Api.Models
{
    public class Store
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        public int AdminId { get; set; }
    }
}
