using Sellix.Net.Models.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sellix.Net.Converters.Order
{
    public class OrderStatusConverter : JsonConverter<OrderStatus>
    {
        public override OrderStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            
        }

        public override void Write(Utf8JsonWriter writer, OrderStatus value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
