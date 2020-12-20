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
                "SERIALS" => ProductType.Serials,
                "FILE" => ProductType.File,
                "SERVICE" => ProductType.Service,
                _ => throw new Exception("Could not parse ProductType"),
            };
        }

        public override void Write(Utf8JsonWriter writer, ProductType value, JsonSerializerOptions options)
        {
            string jsonV = value switch
            {
                ProductType.Serials => "SERIALS",
                ProductType.File => "FILE",
                ProductType.Service => "SERVICE",
                _ => "null",
            };
            writer.WriteStringValue(jsonV);
        }
    }
}
