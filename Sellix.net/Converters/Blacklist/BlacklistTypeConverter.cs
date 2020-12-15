using Sellix.net.Models.Blacklist;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sellix.net.Converters.Blacklist
{
    public class BlacklistTypeConverter : JsonConverter<BlacklistType>
    {
        public override BlacklistType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "email")
            {
                return BlacklistType.email;
            } else if (value == "ip")
            {
                return BlacklistType.ip;
            }
            return BlacklistType.country;
        }

        public override void Write(Utf8JsonWriter writer, BlacklistType value, JsonSerializerOptions options)
        {
            if(value == BlacklistType.country)
            {
                writer.WriteStringValue("country");
            } else if(value == BlacklistType.email)
            {
                writer.WriteStringValue("email");
            } else
            {
                writer.WriteStringValue("ip");
            }
        }
    }
}
