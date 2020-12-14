using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sellix.net.Models.Products
{
    public class ProductList
    {
        [JsonPropertyName("products")]
        public Product[] Prodcuts { get; set; }
    }
}
