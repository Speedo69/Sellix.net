using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Sellix.net.Models.Products
{
    public class Product
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("uniqid")]
        public string Unique { get; set; }
        [JsonPropertyName("shop_id")]
        public int ShopId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("price")]
        public float Price { get; set; }
        [JsonPropertyName("price_display")]
        public float PriceDisplay { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("image_name")]
        public string ImageName { get; set; }
        [JsonPropertyName("image_storage")]
        public string ImageStorage { get; set; }
        [JsonPropertyName("image_attachment")]
        public string ImageAttachment { get; set; }
        [JsonPropertyName("file_attachment")]
        public string FileAttachment { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("quantity_min")]
        public int MinQuantity { get; set; }
        [JsonPropertyName("quantity_max")]
        public int MaxQuantity { get; set; }
        [JsonPropertyName("quantity_warning")]
        public int QuantityWarning { get; set; }
        [JsonPropertyName("delivery_text")]
        public string DeliveryText { get; set; }
        [JsonPropertyName("service_text")]
        public string ServiceText { get; set; }
        [JsonPropertyName("custom_fields")]
        public CustomField[] CustomFields { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("gateways")]
        public string[] Gateways { get; set; }
        [JsonPropertyName("crypto_confirmations_needed")]
        public int CryptoConfNeeded { get; set; }
        [JsonPropertyName("max_risk_level")]
        public int MaxRiskLevel { get; set; }
        [JsonPropertyName("block_vpn_proxies")]
        public bool BlockProxies { get; set; }
        [JsonPropertyName("private")]
        public bool Private { get; set; }
        [JsonPropertyName("stock")]
        public int Stock { get; set; }
        [JsonPropertyName("stock_delimiter")]
        public string StockDelimiter { get; set; }
        [JsonPropertyName("serials")]
        public string[] Serials { get; set; }
        [JsonPropertyName("serials_remove_duplicates")]
        public bool SerialsNoDuplicates { get; set; }
        [JsonPropertyName("dynamic_webhook")]
        public string DynamicWebhook { get; set; }
        [JsonPropertyName("unlisted")]
        public bool Unlisted { get; set; }
        [JsonPropertyName("sort_priority")]
        public int SortPriority { get; set; }
        [JsonPropertyName("terms_of_service")]
        public string TOS { get; set; }
        [JsonPropertyName("warranty")]
        public int Warranty { get; set; }
        [JsonPropertyName("warranty_text")]
        public string WarrantyText { get; set; }
        [JsonPropertyName("created_at")]
        public int CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public int UpdatedAt { get; set; }
        [JsonPropertyName("updated_by")]
        public int UpdatedBy { get; set; }
        [JsonPropertyName("webhooks")]
        public string[] Webhooks { get; set; }
        [JsonPropertyName("feedback")]
        public ProductFeedback Feedback { get; set; }
    }

    public class CustomField
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("required")]
        public bool Required { get; set; }
    }
    public class ProductType
    {
        public string File = "file";
        public string Serials = "serials";
        public string service = "service";
    }
    public class ProductFeedback
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }
        [JsonPropertyName("positive")]
        public int Positive { get; set; }
        [JsonPropertyName("neutral")]
        public int Neutral { get; set; }
        [JsonPropertyName("negative")]
        public int Negative { get; set; }
    }
}
