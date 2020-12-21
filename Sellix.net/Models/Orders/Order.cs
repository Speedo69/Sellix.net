using Sellix.Net.Converters;
using Sellix.Net.Converters.Order;
using Sellix.Net.Models.Products;
using System.Text.Json.Serialization;

namespace Sellix.Net.Models.Orders
{
    public class OrderRoot
    {
        [JsonPropertyName("order")]
        public Order Order { get; set; }
    }

    public class Order
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("uniqid")]
        public string UniqueId { get; set; }
        [JsonPropertyName("total")]
        [JsonConverter(typeof(PriceConverter))]
        public float Total { get; set; }
        [JsonPropertyName("total_display")]
        [JsonConverter(typeof(PriceConverter))]
        public float TotalDisplay { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        [JsonPropertyName("shop_id")]
        public int ShopId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }
        [JsonPropertyName("product_type")]
        public ProductType ProductType { get; set; }
        [JsonPropertyName("product_title")]
        public string ProductTitle { get; set; }
        [JsonPropertyName("file_attachment_uniqid")]
        public string FileAttachmentId { get; set; }
        [JsonPropertyName("gateway")]
        public string Gateway { get; set; }
        [JsonPropertyName("paypal_email")]
        public string PayPalEmail { get; set; }
        [JsonPropertyName("paypal_order_id")]
        public string PayPalOrderId { get; set; }
        [JsonPropertyName("paypal_payer_email")]
        public string PayPalUserEmail { get; set; }
        [JsonPropertyName("skrill_email")]
        public string SkrillEmail { get; set; }
        [JsonPropertyName("skrill_sid")]
        public string SkillSID { get; set; }
        [JsonPropertyName("skrill_link")]
        public string SkrillLink { get; set; }
        [JsonPropertyName("perfectmoney_id")]
        public string PerfectMoneyId { get; set; }
        [JsonPropertyName("crypto_address")]
        public string CryptoAddress { get; set; }
        [JsonPropertyName("crypto_amount")]
        public float CryptoAmount { get; set; }
        [JsonPropertyName("crypto_received")]
        public float CryptoReceived { get; set; }
        [JsonPropertyName("crypto_uri")]
        public string CryptoUri { get; set; }
        [JsonPropertyName("crypto_confirmations_needed")]
        public int CryptoConfNeeded { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("location")]
        public string Location { get; set; }
        [JsonPropertyName("ip")]
        public string Ip { get; set; }
        [JsonPropertyName("is_vpn_or_proxy")]
        public bool IsUsingProxy { get; set; }
        [JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("coupon_id")]
        public string CouponId { get; set; }
        [JsonPropertyName("custom_fields")]
        public object[] CustomFields { get; set; }
        [JsonPropertyName("developer_invoice")]
        public bool IsDeveloperInvoice { get; set; }
        [JsonPropertyName("developer_title")]
        public string DeveloperTitle { get; set; }
        [JsonPropertyName("developer_webhook")]
        public string DeveloperWebhook { get; set; }
        [JsonPropertyName("developer_return_url")]
        public string DeveloperReturnUrl { get; set; }
        [JsonPropertyName("status")]
        public OrderStatus Status { get; set; }
        [JsonPropertyName("to_process")]
        public bool ToProcess { get; set; }
        [JsonPropertyName("discount")]
        public float Discount { get; set; }
        [JsonPropertyName("fee_fixed")]
        public float FixedFee { get; set; }
        [JsonPropertyName("fee_percentage")]
        public float FeePercentage { get; set; }
        [JsonPropertyName("day_value")]
        public int DayValue { get; set; }
        [JsonPropertyName("day")]
        public string Day { get; set; }
        [JsonPropertyName("month")]
        public string Month { get; set; }
        [JsonPropertyName("year")]
        public int Year { get; set; }
        [JsonPropertyName("created_at")]
        public ulong? CreatedAt { get; set; }
        [JsonPropertyName("serials")]
        public string[] Serials { get; set; }
        [JsonPropertyName("status_history")]
        public OrderStatusInfo[] StatusHistory { get; set; }
        [JsonPropertyName("file")]
        public SellixFile File { get; set; }
        public string[] Webhooks { get; set; }
        [JsonPropertyName("crypto_payout")]
        public bool CryptoPayout { get; set; }
        [JsonPropertyName("crypto_payout_transaction")]
        public CryptoTransaction CryptoPayoutTransaction { get; set; }
        [JsonPropertyName("product")]
        public Product Product { get; set; }


    }
    public enum OrderStatus
    {
        Pending,
        Voided,
        Partial,
        Reversed,
        Completed,
        WaitingForConf,
        Refunded,
        ActiveDispute,
        PaymentAuthVoided,
        DisputeUpdated,
        PaymentCaptureCompleted,
        PaymentCaptureDenied,
        DisputeSolved,
        PaymentCaptureRefunded,
        PaymentCaptureReversed,
        PaymentCapturePending,
        PaymentAuthCreated,
        CheckoutOrderApproved,
        CheckoutOrderCompleted,
        CustomerDisputeCreated
    }
    public class OrderStatusHistory
    {
        [JsonPropertyName("status_history")]
        public OrderStatusInfo[] StatusArray { get; set; }
    }
    public class OrderStatusInfo
    {
        [JsonPropertyName("created_at")]
        public ulong? CreatedAt { get; set; }
        [JsonPropertyName("details")]
        public string Details { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }
        [JsonPropertyName("status")]
        [JsonConverter(typeof(OrderStatusConverter))]
        public OrderStatus Status { get; set; }
    }
}
