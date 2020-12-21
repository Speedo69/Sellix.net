using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sellix.Net.Models.Orders
{
    public class OrderList
    {
        [JsonPropertyName("orders")]
        public Order[] Orders { get; set; }
    }
}
