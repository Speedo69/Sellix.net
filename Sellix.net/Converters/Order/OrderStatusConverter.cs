using Sellix.Net.Models.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sellix.Net.Converters.Order
{
    //Faster than dictionary, POG!!!
    public class OrderStatusConverter : JsonConverter<OrderStatus>
    {
        public override OrderStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var status = reader.GetString();
            return status switch
            {
                "PENDING" => OrderStatus.Pending,
                "VOIDED" => OrderStatus.Voided,
                "PARTIAL" => OrderStatus.Partial,
                "REVERSED" => OrderStatus.Reversed,
                "COMPLETED" => OrderStatus.Completed,
                "WAITING_FOR_CONFIRMATIONS" => OrderStatus.WaitingForConf,
                "REFUNDED" => OrderStatus.Refunded,

                "CUSTOMER_DISPUTE_CREATED" => OrderStatus.CustomerDisputeCreated,
                "CUSTOMER_DISPUTE_ONGOING" => OrderStatus.ActiveDispute,
                "CUSTOMER_DISPUTE_UPDATED" => OrderStatus.DisputeUpdated,
                "CUSTOMER_DISPUTE_RESOLVED" => OrderStatus.DisputeSolved,

                "PAYMENT_AUTHORIZATION_CREATED" => OrderStatus.PaymentAuthCreated,
                "PAYMENT_AUTHORIZATION_VOIDED" => OrderStatus.PaymentAuthVoided,

                "PAYMENT_CAPTURE_COMPLETED" => OrderStatus.PaymentCaptureCompleted,
                "PAYMENT_CAPTURE_DENIED" => OrderStatus.PaymentCaptureDenied,
                "PAYMENT_CAPTURE_REFUNDED" => OrderStatus.PaymentCaptureRefunded,
                "PAYMENT_CAPTURE_REVERSED" => OrderStatus.PaymentCaptureReversed,
                "PAYMENT_CAPTURE_PENDING" => OrderStatus.PaymentCapturePending,

                "CHECKOUT_ORDER_APPROVED" => OrderStatus.CheckoutOrderApproved,
                "CHECKOUT_ORDER_COMPLETED" => OrderStatus.CheckoutOrderCompleted,
                _ => throw new Exception($"Unknown status {status}")
            };
        }

        public override void Write(Utf8JsonWriter writer, OrderStatus value, JsonSerializerOptions options)
        {
            var jsonV = value switch
            {
                OrderStatus.Pending => "PENDING",
                OrderStatus.Voided => "VOIDED",
                OrderStatus.Partial => "PARTIAL",
                OrderStatus.Reversed => "REVERSED",
                OrderStatus.Completed => "COMPLETED",
                OrderStatus.WaitingForConf => "WAITING_FOR_CONFIRMATIONS",
                OrderStatus.Refunded => "REFUNDED",

                OrderStatus.CustomerDisputeCreated => "CUSTOMER_DISPUTE_CREATED",
                OrderStatus.ActiveDispute => "CUSTOMER_DISPUTE_ONGOING",
                OrderStatus.DisputeUpdated => "CUSTOMER_DISPUTE_UPDATED",
                OrderStatus.DisputeSolved => "CUSTOMER_DISPUTE_RESOLVED",

                OrderStatus.PaymentAuthCreated => "PAYMENT_AUTHORIZATION_CREATED",
                OrderStatus.PaymentAuthVoided => "PAYMENT_AUTHORIZATION_VOIDED",

                OrderStatus.PaymentCaptureCompleted => "PAYMENT_CAPTURE_COMPLETED",
                OrderStatus.PaymentCaptureDenied => "PAYMENT_CAPTURE_DENIED",
                OrderStatus.PaymentCaptureRefunded => "PAYMENT_CAPTURE_REFUNDED",
                OrderStatus.PaymentCaptureReversed => "PAYMENT_CAPTURE_REVERSED",
                OrderStatus.PaymentCapturePending => "PAYMENT_CAPTURE_PENDING",

                OrderStatus.CheckoutOrderApproved => "CHECKOUT_ORDER_APPROVED",
                OrderStatus.CheckoutOrderCompleted => "CHECKOUT_ORDER_COMPLETED",
                _ => throw new NotImplementedException()
            };
            writer.WriteStringValue(jsonV);
        }
    }
}
