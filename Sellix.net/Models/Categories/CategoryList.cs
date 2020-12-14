using System.Text.Json.Serialization;

namespace Sellix.net.API.Categories.Models
{
    public class CategoryList
    {
        [JsonPropertyName("categories")]
        public Category[] Categories { get; set; }
    }
}
