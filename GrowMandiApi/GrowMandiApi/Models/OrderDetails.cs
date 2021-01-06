using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class OrderDetails
    {
        public OrderDetails()
        {
            OrderProductDetails = new HashSet<OrderProductDetails>();
        }

        public int OrderId { get; set; }
        public string RetailerId { get; set; }
        public string RetailerMobile { get; set; }
        public string Totalprice { get; set; }
        public string PaymentMode { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? ShippingAddressId { get; set; }
        public string OrderStatus { get; set; }
        public string SapOrderId { get; set; }
        public string GeoCoordinates { get; set; }
        public string RzpOrderId { get; set; }
        public string RzpPaymentId { get; set; }
        public string RzpSignature { get; set; }
        public string RzpPaymentStatus { get; set; }

        public virtual UserInfo RetailerMobileNavigation { get; set; }
        public virtual ICollection<OrderProductDetails> OrderProductDetails { get; set; }
    }
}
