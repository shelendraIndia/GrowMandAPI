using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiCartInfo
    {
        public long CartId { get; set; }
        public string CartType { get; set; }
        public int? FkEnquiryId { get; set; }
        public long? FkInterestedProductId { get; set; }
        public string DealId { get; set; }
        public long? ProductId { get; set; }
        public string Product { get; set; }
        public string Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public int? Price { get; set; }
        public string ProductImage { get; set; }
        public string ProductAddress { get; set; }
        public string BuyerName { get; set; }
        public string BuyerNumber { get; set; }
        public string BuyerAddress { get; set; }
        public string SellerName { get; set; }
        public string SellerMobileNumber { get; set; }
        public string SellerAddress { get; set; }
        public decimal? LogisticsCost { get; set; }
        public decimal? OtherCharges { get; set; }
        public decimal? Taxes { get; set; }
        public long? FkProductStatus { get; set; }
        public string Remarks { get; set; }
        public decimal? ServiceTax { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual MandiUserEnquiry FkEnquiry { get; set; }
        public virtual MandiInterestedProductForUser FkInterestedProduct { get; set; }
        public virtual MandiCartProductStatus FkProductStatusNavigation { get; set; }
    }
}
