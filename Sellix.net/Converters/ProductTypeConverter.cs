using Sellix.Net.Models.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sellix.Net.Converters
{
    public class ProductTypeConverter : JsonConverter<ProductType>
    {
        public override ProductType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "serials" => ProductType.Serials,
                "file" => ProductType.File,
                "service" => ProductType.Service,
                _ => throw new Exception("Could not parse ProductType"),
            };
        }

        public override void Write(Utf8JsonWriter writer, ProductType value, JsonSerializerOptions options)
        {
            string jsonV = value switch
            {
                ProductType.Serials => "serials",
                ProductType.File => "file",
                ProductType.Service => "service",
                _ => "null",
            };
            writer.WriteStringValue(jsonV);
        }
    }
}
