using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sellix.net.Converters
{
    public class BoolConverter : JsonConverter<bool>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(bool);
        }

        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.ValueSpan.ToString() == "1";
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            writer.WriteBooleanValue(value);
        }
    }
}
