using System.Text.Json.Serialization;

namespace Sellix.net.Models.Feedback
{
    public class Feedback
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("uniqid")]
        public string UniqueId { get; set; }
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }
        [JsonPropertyName("shop_id")]
        public int ShopId { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
        [JsonPropertyName("reply")]
        public string Reply { get; set; }
        [JsonPropertyName("feedback")]
        public string UserFeedback { get; set; }
        [JsonPropertyName("score")]
        public int Score { get; set; }
        [JsonPropertyName("invoice")]
        public object Invoice { get; set; }
        [JsonPropertyName("product")]
        public Products.Product ProductInfo { get; set; }
        [JsonPropertyName("created_at")]
        public int? CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public int? UpdatedAt { get; set; }
        [JsonPropertyName("updated_by")]
        public int? UpdatedBy { get; set; }
    }
}
