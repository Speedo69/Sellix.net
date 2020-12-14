using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sellix.net.Converters
{
    public class BoolConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if(reader.TokenType == JsonTokenType.False || reader.TokenType == JsonTokenType.True)
            {
                return reader.TokenType == JsonTokenType.True;
            }
            else if(reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetInt16() == 1;
            } else if (reader.TokenType == JsonTokenType.String)
            {
                return reader.GetString() == "1";
            }
            throw new Exception("Couldn't not parse boolean");
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            writer.WriteBooleanValue(value);
        }
    }
}
