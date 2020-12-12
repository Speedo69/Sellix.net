using System.Text.Json.Serialization;

namespace Sellix.net.API.Categories.Models
{
    public class Categories
    {
        [JsonPropertyName("categories")]
        public Category[] categories { get; set; }
    }
}
