using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sellix.net.API
{
    public class Response<DataType>
    {
        [JsonPropertyName("status")]
        public int Status { get; set; }
        [JsonPropertyName("data")]
        public DataType Data { get; set; }
        [JsonPropertyName("message")]
        public object Message { get; set; }
        [JsonPropertyName("log")]
        public object Log { get; set; }
        [JsonPropertyName("error")]
        public string Error { get; set; }
        [JsonPropertyName("env")]
        public string Env { get; set; }
    }
}
