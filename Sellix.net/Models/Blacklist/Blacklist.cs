using Sellix.Net.Converters.Blacklist;
using System.Text.Json.Serialization;

namespace Sellix.Net.Models.Blacklist
{
    public class BlacklistRoot
    {
        [JsonPropertyName("blacklist")]
        public Blacklist Blacklist { get; set; }
    }
    public class Blacklist
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("uniqid")]
        public string UniqueId { get; set; }
        [JsonPropertyName("shop_id")]
        public int ShopId { get; set; }
        [JsonPropertyName("type")]
        [JsonConverter(typeof(BlacklistTypeConverter))]
        public BlacklistType Type { get; set; }
        [JsonPropertyName("data")]
        public string Data { get; set; }
        [JsonPropertyName("note")]
        public string Note { get; set; }
        [JsonPropertyName("created_at")]
        public int? CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public int? UpdatedAt { get; set; }
        [JsonPropertyName("updated_by")]
        public int? UpdatedBy { get; set; }

    }
    public enum BlacklistType
    {
        ip = 0,
        email = 1,
        country = 2
    }
}
