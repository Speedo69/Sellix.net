using Sellix.net.Models.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sellix.net.Converters
{
    public class ProductTypeConverter : JsonConverter<ProductType>
    {
        public override ProductType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch(value)
            {
                case "serials": return ProductType.Serials;
                case "file": return ProductType.File;
                case "service": return ProductType.Service;
                default: throw new Exception("Could not parse ProductType");
            }
        }

        public override void Write(Utf8JsonWriter writer, ProductType value, JsonSerializerOptions options)
        {
            string jsonV = "";
            switch (value)
            {
                case ProductType.Serials: jsonV = "serials"; break;
                case ProductType.File: jsonV = "file"; break;
                case ProductType.Service: jsonV = "service"; break;
                default: jsonV = "null"; break;
            }
            writer.WriteStringValue(jsonV);
        }
    }
}
