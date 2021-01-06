using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiOrderDetails
    {
        public int OrderId { get; set; }
        public string BuyerMobile { get; set; }
        public string TotalPrice { get; set; }
        public decimal? ServiceTax { get; set; }
        public string TotalAmount { get; set; }
        public string PaymentMode { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? ShippingAddressId { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderStatus { get; set; }
        public string RzpOrderId { get; set; }
        public string RzpPaymentId { get; set; }
        public string RzpPaymentStatus { get; set; }
        public string RzpPaymentSignature { get; set; }
        public string SelectedTotalQty { get; set; }
        public string BuyerName { get; set; }
        public string GeoAddress { get; set; }
        public string TransactionId { get; set; }
        public string ResponseCode { get; set; }
        public string TransactionStatus { get; set; }
        public string OfferDiscountValue { get; set; }
        public string OfferTransactionId { get; set; }
    }
}
