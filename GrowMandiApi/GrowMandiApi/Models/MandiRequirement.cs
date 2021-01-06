using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiRequirement
    {
        public long Id { get; set; }
        public string MobileNumber { get; set; }
        public string BuyerId { get; set; }
        public string BuyerContact { get; set; }
        public string BuyerAddress { get; set; }
        public string CropName { get; set; }
        public string Variety { get; set; }
        public string Quantity { get; set; }
        public string QualitySpecification { get; set; }
        public string DeliveryLocation { get; set; }
        public string ExpectedPrice { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public bool? IsPriceNegotiable { get; set; }
        public string Remarks { get; set; }
        public DateTime? TrDate { get; set; }
    }
}
