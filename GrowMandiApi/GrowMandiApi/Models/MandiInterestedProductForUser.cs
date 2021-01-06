using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiInterestedProductForUser
    {
        public MandiInterestedProductForUser()
        {
            MandiCartInfo = new HashSet<MandiCartInfo>();
        }

        public long Id { get; set; }
        public string FkMobileNumber { get; set; }
        public string BuyerId { get; set; }
        public string BuyerAddress { get; set; }
        public string ProductId { get; set; }
        public string CropName { get; set; }
        public string VarietyName { get; set; }
        public string Quantity { get; set; }
        public string QualitySpecification { get; set; }
        public string DeliveryLocation { get; set; }
        public string ExpectedPrice { get; set; }
        public string IsPriceNegotiable { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual MandiUserInfo FkMobileNumberNavigation { get; set; }
        public virtual ICollection<MandiCartInfo> MandiCartInfo { get; set; }
    }
}
