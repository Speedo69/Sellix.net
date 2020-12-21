using System.Text.Json.Serialization;

namespace Sellix.Net.Models
{
    public class CryptoTransaction
    {
        [JsonPropertyName("to_address")]
        public string ToAddress { get; set; }
        [JsonPropertyName("from_address")]
        public string FromAddress { get; set; }
        [JsonPropertyName("crypto_amount")]
        public float Amount { get; set; }
        [JsonPropertyName("hash")]
        public string Hash { get; set; }
        [JsonPropertyName("created_at")]
        public ulong? CreatedAt { get; set; }
        [JsonPropertyName("confirmations")]
        public int? Confirmations { get; set; }
        [JsonPropertyName("updated_at")]
        public ulong? UpdatedAt { get; set; }
    }
}
