using System.Text.Json.Serialization;

namespace Sellix.Net.Models.Coupons
{
    public class CouponRoot
    {
        public Coupon Coupon { get; set; }
    }

    public class Coupon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("uniqid")]
        public string UniqueId { get; set; }
        [JsonPropertyName("shop_id")]
        public int ShopId { get; set; }
        [JsonPropertyName("code")]
        public string Code { get; set; }
        [JsonPropertyName("use_type")]
        public int UseType { get; set; }
        [JsonPropertyName("discount")]
        public float Discount { get; set; }
        [JsonPropertyName("used")]
        public int UsedCount { get; set; }
        [JsonPropertyName("max_uses")]
        public int MaxUses { get; set; }
        [JsonPropertyName("products_bound")]
        public string[] BoundProducts { get; set; }
        [JsonPropertyName("products_count")]
        public int BoundProductsCount { get; set; }
        [JsonPropertyName("created_at")]
        public int? CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public int? UpdatedAt { get; set; }
        [JsonPropertyName("updated_by")]
        public int? UpdatedBy { get; set; }
    }
}
