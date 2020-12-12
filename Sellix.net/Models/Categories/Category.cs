using Sellix.net.Models.Products;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sellix.net.API.Categories.Models
{
    public class CategoryRoot
    {
        [JsonPropertyName("category")]
        public Category Category { get; set; }
    }

    public class Category
    {
        public Category()
        {
        }
        
        public Category(bool unlisted, string title, int sortPriority, string[] productsBoundIds)
        {
            Unlisted = unlisted;
            Title = title;
            SortPriority = sortPriority;
            ProductsBound = productsBoundIds;
        }

        [JsonPropertyName("id")]
            public int Id { get; set; }
            [JsonPropertyName("uniqid")]
            public string UniqueId { get; set; }
            [JsonPropertyName("shop_id")]
            public int Shop_id { get; set; }
            [JsonPropertyName("unlisted")]
            public bool Unlisted { get; set; }
            [JsonPropertyName("title")]
            public string Title { get; set; } 
            [JsonPropertyName("sort_priority")]
            public int SortPriority { get; set; }
            [JsonPropertyName("products_bound")]
            public object[] ProductsBound { get; set; }
            [JsonPropertyName("products_count")]
            public int ProductsCount { get; set; }
            [JsonPropertyName("created_at")]
            public int CreatedAt { get; set; }
            [JsonPropertyName("updated_at")]
            public int UpdatedAt { get; set; }
            [JsonPropertyName("updated_by")]
            public int UpdatedBy { get; set; }
            public Product[] GetProducts() {
                if(ProductsBound.Length >= 1)
                {
                //this is utterly retarded, but i guess it works and i am too lazy to come up with proper solution.
                return JsonSerializer.Deserialize<Product[]>(JsonSerializer.Serialize(ProductsBound));    
                }
                return null;
            } 
    }
}
