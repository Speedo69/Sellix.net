using System.Text.Json.Serialization;

namespace Sellix.Net.Models.Categories
{
    public class CategoryList
    {
        [JsonPropertyName("categories")]
        public Category[] Categories { get; set; }
    }
}
