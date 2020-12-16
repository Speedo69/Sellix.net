using System.Text.Json.Serialization;

namespace Sellix.Net.Models
{
    public class Response<DataModel>
    {
        [JsonPropertyName("status")]
        public int Status { get; set; }
        [JsonPropertyName("data")]
        public DataModel Data { get; set; }
        [JsonPropertyName("message")]
        public object Message { get; set; }
        [JsonPropertyName("log")]
        public object Log { get; set; }
        [JsonPropertyName("error")]
        public string Error { get; set; }
        [JsonPropertyName("env")]
        public string Env { get; set; }
    }
    public class UniqId
    {
        [JsonPropertyName("uniqid")]
        public string? UniqueId { get; set; }
    }
}
