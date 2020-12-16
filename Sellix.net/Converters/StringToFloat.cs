using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sellix.Net.Converters
{
    public class StringToFloat : JsonConverter<float>
    {
        public override float Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return float.Parse(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
}
