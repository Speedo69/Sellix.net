using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sellix.net.Converters
{

    //API v1 is literally retarded, the price gets returned either as a String or Single. WTF!
    public class PriceConverter : JsonConverter<float>
    {
        public override float Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            
            if(reader.TokenType == JsonTokenType.String)
            {
                return float.Parse(reader.GetString());
            } else if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetSingle();
            }
            throw new Exception("Price conversion failed");
        }

        public override void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
}
